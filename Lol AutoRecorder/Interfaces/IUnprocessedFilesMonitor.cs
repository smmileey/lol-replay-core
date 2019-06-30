using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IUnprocessedFilesMonitor
    {
        Task<bool> CheckForUnprocessedFilesAsync(string recordingSavePath);

        Task DeleteUnprocessedFilesAsync(string recordingSavePath);
    }
}