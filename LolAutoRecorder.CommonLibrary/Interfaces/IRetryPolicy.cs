using System;
using System.Threading.Tasks;

namespace LolAutoRecorder.CommonLibrary.Interfaces
{
    public interface IRetryPolicy
    {
        Task ExecuteAsync(Func<Task> factory, Func<bool> condition, int maxRetries = 10, int delayBetweenRequests = 10000);

        T Execute<T>(Func<T> factory, Func<T, bool> condition, int maxRetries = 10, int delayBetweenRequest = 10000);

        Task<T> ExecuteAsync<T>(Func<Task<T>> factory, Func<T, bool> condition, int maxRetries = 10, int delayBetweenRequest = 10000);
    }
}