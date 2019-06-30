namespace Lol_AutoRecorder.Constants
{
    public static class Error
    {
        public const string InvalidMetadataFileError = "Invalid recording metadata file! Stopping the recording.";
        public const string LaunchingReplayError = "There was an error launching the replay. Check provided filepaths.";
        public const string CriticalError = "There was a critical error on recording saving. Stopping the recording process. Please see the logs for details.";
        public const string CreateRecordingError = "Cannot create recording. Check if selected recording save path is valid.";
        public const string ReplayApiNotRespondingError = "Replay API is not responding. Please make sure you have a client running. Stopping the recording.";
        public const string LeagueClientNotRespondingError = "League Client is not responding. This is often happening when alt+tab while recording on full screen (LoL client related issue). The client was terminated.";
        public const string UnhandledExceptionError = "Unhandled excepiton occured. Please send the logs to smmileey@gmail.com so I can fix it.";
        public const string IncorrecServerDataError = "Incorect data from server.";
        public const string PlayerIdNotFoundError = "Player id not found!";
        public const string InvalidPathError = "Invalid path. See inner exception for details";
    }
}
