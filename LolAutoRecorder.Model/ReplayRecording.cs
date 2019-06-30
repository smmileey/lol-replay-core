using Newtonsoft.Json;

namespace LolAutoRecorder.Model
{
    [JsonObject]
    public class ReplayRecording
    {
        [JsonProperty("codec")]
        public string Codec { get; set; }

        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        [JsonProperty("enforceFrameRate")]
        public bool EnforceFrameRate { get; set; }

        [JsonProperty("framesPerSecond")]
        public int FramesPerSecond { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("lossless")]
        public bool Lossless { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("recording")]
        public bool Recording { get; set; }

        [JsonProperty("replaySpeed")]
        public int ReplaySpeed { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
