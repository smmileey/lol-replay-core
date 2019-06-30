using LolAutoRecorder.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IReplayPlaybackProvider
    {
        Task<List<ReplayPlayback>> ProvideAsync(string pathToMedatadaFile);
    }
}