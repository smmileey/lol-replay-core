using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Repositories
{
    public class RestRepository : IRestRepository
    {
        public async Task<T> GetAsync<T>(string url) where T : new()
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                var taskCompletionSource = new TaskCompletionSource<T>();
                client.ExecuteAsync<T>(request, response =>
                {
                    taskCompletionSource.SetResult(response.Data);
                });
                return await taskCompletionSource.Task;
            }
            catch (Exception exception)
            {
                throw new RestRepositoryException("Incorrect response from server. ", exception);
            }
        }

        public async Task<T> PostAsync<T>(string url, T body) where T : new()
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddJsonBody(JsonConvert.SerializeObject(body));
                var taskCompletionSource = new TaskCompletionSource<T>();

                client.ExecuteAsync<T>(request, response =>
                {
                    taskCompletionSource.SetResult(response.Data);
                });

                return await taskCompletionSource.Task;
            }
            catch (Exception exception)
            {
                throw new RestRepositoryException("Incorrect response from server. ", exception);
            }

        }
    }
}
