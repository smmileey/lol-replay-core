using Newtonsoft.Json;

namespace LolAutoRecorder.Model
{
    [JsonObject]
    public class ReplayPlayback
    {

        [JsonProperty("length")]
        public int Length { get; set; }


        [JsonProperty("paused")]
        public bool Paused { get; set; }


        [JsonProperty("seeking")]
        public bool Seeking { get; set; }


        [JsonProperty("speed")]
        public int Speed { get; set; }


        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("championName")]
        public string ChampionName { get; set; }
    }
}
