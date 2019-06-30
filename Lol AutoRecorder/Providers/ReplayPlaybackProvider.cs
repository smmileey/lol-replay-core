using Lol_AutoRecorder.Exceptions;
using Lol_AutoRecorder.Interfaces;
using LolAutoRecorder.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Providers
{
    public class ReplayPlaybackProvider : IReplayPlaybackProvider
    {
        public async Task<List<ReplayPlayback>> ProvideAsync(string pathToMedatadaFile)
        {
            if (string.IsNullOrEmpty(pathToMedatadaFile)) throw new ReplayPlaybackProviderException($"Argument: {pathToMedatadaFile} not specified.");

            try
            {
                return await Task.Run(() =>
                {
                    List<ReplayPlayback> replayPlaybacks = new List<ReplayPlayback>();
                    using (StreamReader r = new StreamReader(pathToMedatadaFile))
                    {
                        string json = r.ReadToEnd();
                        replayPlaybacks = JsonConvert.DeserializeObject<List<ReplayPlayback>>(json);
                    }
                    return replayPlaybacks;
                });         
            }
            catch (Exception exception)
            {
                throw new ReplayPlaybackProviderException($"Error occured while retrieving replay playbacks. See inner exceptions for details.", exception);
            }
        }
    }
}
