using LolAutoRecorder.Model;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IReplayRepository
    {
        Task<ReplayRecording> GetReplayRecordingAsync();

        Task<Recording> GetRecordingAsync();

        Task<ReplayPlayback> SetupRecordingAsync(ReplayPlayback replayPlayback);

        Task<Recording> RecordAsync(Recording recordingInfo);
    }
}