using Lol_AutoRecorder.Interfaces;
using LolAutoRecorder.CommonLibrary.Interfaces;
using LolAutoRecorder.Model;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Repositories
{
    public class ReplayRepository : IReplayRepository
    {
        const string ReplayRecordingURL = "https://127.0.0.1:2999/replay/recording";
        const string ReplayPlaybackURL = "https://127.0.0.1:2999/replay/playback";

        private readonly IRestRepository _restRepostory;
        private readonly IRetryPolicy _retryPolicy;

        public ReplayRepository(IRestRepository restRepostory, IRetryPolicy retryPolicy)
        {
            _restRepostory = restRepostory ?? throw new System.ArgumentNullException(nameof(restRepostory));
            _retryPolicy = retryPolicy ?? throw new System.ArgumentNullException(nameof(retryPolicy));
        }

        public async Task<ReplayRecording> GetReplayRecordingAsync()
        {
            return await _retryPolicy.ExecuteAsync(
                async () => await _restRepostory.GetAsync<ReplayRecording>(ReplayRecordingURL),
                replayRecordingTask => IsRecordingStarted(replayRecordingTask));
        }

        public async Task<Recording> GetRecordingAsync()
        {
            return await _retryPolicy.ExecuteAsync(
                async () => await _restRepostory.GetAsync<Recording>(ReplayRecordingURL),
                recordingTask => IsRecordingFinished(recordingTask));
        }

        public async Task<ReplayPlayback> SetupRecordingAsync(ReplayPlayback replayPlayback)
        {
            if (replayPlayback == null) throw new System.ArgumentNullException(nameof(replayPlayback));

            return await _restRepostory.PostAsync(ReplayPlaybackURL, replayPlayback);
        }

        public async Task<Recording> RecordAsync(Recording recordingInfo)
        {
            if (recordingInfo == null) throw new System.ArgumentNullException(nameof(recordingInfo));

            return await _restRepostory.PostAsync(ReplayRecordingURL, recordingInfo);
        }

        private bool IsRecordingStarted(ReplayRecording replayRecordingTask)
        {
            return replayRecordingTask != null && replayRecordingTask.CurrentTime > 0;
        }

        private bool IsRecordingFinished(Recording recording)
        {
            return recording != null && !recording.IsRecording;
        }
    }
}
