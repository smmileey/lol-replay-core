using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using Ninject.Extensions.Logging;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Processors
{
    public class LeagueClientLauncher : ILeagueClientLauncher
    {
        private readonly ILogger _logger;

        public LeagueClientLauncher(ILogger logger)
        {
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }

        public async Task RunAsync(string leagueClientPath, string leagueClientExecutableName, string roflFilePath)
        {
            _logger.Debug("Trying to run LoL process.");

            if (string.IsNullOrEmpty(leagueClientPath)) throw new LeagueClientLauncherException($"Argument: {leagueClientPath} not specified");
            if (string.IsNullOrEmpty(leagueClientExecutableName)) throw new LeagueClientLauncherException($"Argument: {leagueClientExecutableName} not specified");
            if (string.IsNullOrEmpty(roflFilePath)) throw new LeagueClientLauncherException($"Argument: {roflFilePath} not specified");

            await Task.Run(() =>
            {
                string diskRegex = ".+:";
                Match diskMatch = Regex.Match(leagueClientPath, diskRegex);
                if (!diskMatch.Success) throw new LeagueClientLauncherException($"No disk found in path: {leagueClientPath}");

                string disk = diskMatch.Value;
                _logger.Debug($"Disk found: {diskMatch}");
                string command = $"{disk} & cd { leagueClientPath} & \"{leagueClientExecutableName}\" \"{roflFilePath}\"";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}",
                    CreateNoWindow = true
                };
                process.StartInfo = startInfo;
                process.Start();

                _logger.Debug($"LoL process command executed.");
            });
        }
    }
}
