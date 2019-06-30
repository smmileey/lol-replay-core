using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface ILeagueClientLauncher
    {
        Task RunAsync(string leagueClientPath, string leagueClientExecutableName, string roflFilePath);
    }
}