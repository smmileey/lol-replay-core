using Newtonsoft.Json;

namespace LolAutoRecorder.Model
{
    [JsonObject]
    public class Recording
    {
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        [JsonProperty(PropertyName = "currentTime")]
        public double CurrentTime { get; set; }

        [JsonProperty(PropertyName = "endTime")]
        public int EndTime { get; set; }

        [JsonProperty(PropertyName = "enforceFrameRate")]
        public bool EnforceFrameRate { get; set; }

        [JsonProperty(PropertyName = "framesPerSecond")]
        public int FramesPerSecond { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "lossless")]
        public bool Lossless { get; set; }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [JsonProperty(PropertyName = "recording")]
        public bool IsRecording { get; set; }

        [JsonProperty(PropertyName = "replaySpeed")]
        public int ReplaySpeed { get; set; }

        [JsonProperty(PropertyName = "startTime")]
        public int StartTime { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
    }
}
