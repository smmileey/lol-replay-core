namespace Lol_AutoRecorder.Constants
{
    public static class Info
    {

        public const string CancelInfo = "Cancelled!";
        public const string NewProcessStartInfo = "Starting new task for recording process. ";
        public const string ProvideSavePathInfo = "Path to save recordings not provided. Stopping the process.";
        public const string AntoherClientExecutingInfo = "Another LoL process running, waiting for user's decision on how to proceed. ";
        public const string ProcessAbortInfo = "Aborting recording process. ";
        public const string ClientProcessAbortInfo = "Terminating LoL process...";
        public const string WaitingForClientToStartInfo = "Waiting for the League client to start...";
        public const string LeagueClientStaredInfo = "League of Legends client has started successfully.";
        public const string DeletingTemporaryFilesInfo = "Deleting existing temporary files...";
        public const string GettingSummonerFocusInfo = "Getting summoner to focus on. If no such found, default client camera will be used.";
        public const string FocusingOnChampionInfo = "Focusing on a chosen champion...";
        public const string WaitingForUnsavedRecordingsInfo = "Waiting for unsaved recording to be processed";
        public const string RecordingCompleteInfo = "Recording has finished!";
        public const string CleaningDataInfo = "Cleaning current state info after the recording process..";
        public const string AppClosedInfo = "Application closed.";
        public const string TerminatingClientInfo = "Terminating LoL client process.";
    }
}
