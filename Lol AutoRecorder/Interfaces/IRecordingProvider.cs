using LolAutoRecorder.Model;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IRecordingProvider
    {
        Recording Provide(ReplayPlayback replayPlaybackInfo, int replaySpeed, int framesPerSecond, string recordingSavePath);
    }
}