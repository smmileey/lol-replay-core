using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using LolAutoRecorder.CommonLibrary.Exceptions;
using LolAutoRecorder.CommonLibrary.Interfaces;
using Ninject.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Processors
{
    public class UnprocessedFilesMonitor : IUnprocessedFilesMonitor
    {
        private const string TemporaryFilesPattern = "*.tmp";
        private const string LeagueClientProcess = "League of Legends";

        private readonly IRetryPolicy _retryPolicy;
        private readonly ILogger _logger;

        public UnprocessedFilesMonitor(IRetryPolicy retryPolicy, ILogger logger)
        {
            _retryPolicy = retryPolicy ?? throw new System.ArgumentNullException(nameof(retryPolicy));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Check for any recording that are still being saved to the disk. 
        /// </summary>
        /// <param name="recordingSavePath"></param>
        /// <returns>True if any of files are still being processed. </returns>
        public async Task<bool> CheckForUnprocessedFilesAsync(string recordingSavePath)
        {
            try
            {
                if (string.IsNullOrEmpty(recordingSavePath)) throw new UnprocessedFilesMonitorException($"Argument:{recordingSavePath} not provided.");

                Process leagueOfLegendsProcess = Process.GetProcessesByName(LeagueClientProcess).First();
                var recordings = await _retryPolicy.ExecuteAsync(async () =>
                {
                    return await Task.Run(() =>
                    {
                        if (!leagueOfLegendsProcess.Responding) throw new LeagueOfLegendsProcessException($"LeagueClient is not responding. ");
                        var filesFound = Directory.GetFiles(recordingSavePath, TemporaryFilesPattern);
                        _logger.Debug($"Found {filesFound.Length} temporary files.");
                        return filesFound;
                    });
                }, records => records.Length == 0, delayBetweenRequest: 1000, maxRetries: 20);

                return recordings.Length == 0;
            }
            catch (RetryPolicyException retryPolicyException)
            {
                throw new UnprocessedFilesMonitorException($"There was an error trying to execute unprocessed files check. See inner exception forsetails.", retryPolicyException);
            }
            catch (LeagueOfLegendsProcessException exception)
            {
                throw new LeagueOfLegendsProcessException($"League of Legends client exception. ", exception);
            }
            catch (Exception exception)
            {
                throw new UnprocessedFilesMonitorException($"There was an unexpected error in unprocessed files processor. See inner exception for details. ", exception);
            }
        }

        public async Task DeleteUnprocessedFilesAsync(string recordingSavePath)
        {
            try
            {
                if (string.IsNullOrEmpty(recordingSavePath)) throw new UnprocessedFilesMonitorException($"Argument:{recordingSavePath} not provided.");

                await Task.Run(() =>
                {
                    var directoryInfo = new DirectoryInfo(recordingSavePath);
                    foreach (var file in directoryInfo.GetFiles(TemporaryFilesPattern))
                    {
                        _logger.Debug($"Deleting file: {file.FullName}");
                        file.Delete();
                    }
                });

            }
            catch (Exception exception)
            {
                throw new UnprocessedFilesMonitorException($"There was an unexpected error in unprocessed files processor. See inner exception for details. ", exception);
            }
        }
    }
}
