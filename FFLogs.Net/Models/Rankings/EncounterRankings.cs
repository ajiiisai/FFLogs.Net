using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Rankings
{
    public class EncounterRankings
    {
        [JsonPropertyName("page")]
        public long Page { get; set; }

        [JsonPropertyName("hasMorePages")]
        public bool HasMorePages { get; set; }

        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("rankings")]
        public Ranking[] Rankings { get; set; }
    }

    public class Ranking
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("class")]
        public long Class { get; set; }
        [JsonPropertyName("spec")]
        public long Spec { get; set; }
        [JsonPropertyName("total")]
        public double Total { get; set; }
        [JsonPropertyName("duration")]
        public long Duration { get; set; }
        [JsonPropertyName("startTime")]
        public long StartTime { get; set; }
        [JsonPropertyName("fightID")]
        public long FightId { get; set; }
        [JsonPropertyName("reportID")]
        public string ReportId { get; set; }
        [JsonPropertyName("guildName")]
        public string GuildName { get; set; }
        [JsonPropertyName("serverName")]
        public string ServerName { get; set; }
        [JsonPropertyName("regionName")]
        public string RegionName { get; set; }
        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }
        [JsonPropertyName("patch")]
        public double Patch { get; set; }
        [JsonPropertyName("other_per_second_amount")]
        public double OtherPerSecondAmount { get; set; }
        [JsonPropertyName("raw_dps")]
        public double RawDps { get; set; }
        [JsonPropertyName("exploit")]
        public long Exploit { get; set; }
    }
}