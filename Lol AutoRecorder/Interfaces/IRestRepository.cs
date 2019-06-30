using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IRestRepository
    {
        Task<T> GetAsync<T>(string url) where T : new();

        Task<T> PostAsync<T>(string url, T body) where T : new();
    }
}