using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Parses
{
    public partial class Parses
    {
        [JsonPropertyName("encounterID")]
        public long EncounterId { get; set; }

        [JsonPropertyName("encounterName")]
        public string EncounterName { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("spec")]
        public string Spec { get; set; }

        [JsonPropertyName("rank")]
        public long Rank { get; set; }

        [JsonPropertyName("outOf")]
        public long OutOf { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        [JsonPropertyName("startTime")]
        public long StartTime { get; set; }

        [JsonPropertyName("reportID")]
        public string ReportId { get; set; }

        [JsonPropertyName("fightID")]
        public long FightId { get; set; }

        [JsonPropertyName("difficulty")]
        public long Difficulty { get; set; }

        [JsonPropertyName("characterID")]
        public long CharacterId { get; set; }

        [JsonPropertyName("characterName")]
        public string CharacterName { get; set; }

        [JsonPropertyName("server")]
        public string Server { get; set; }

        [JsonPropertyName("percentile")]
        public double Percentile { get; set; }

        [JsonPropertyName("ilvlKeyOrPatch")]
        public double IlvlKeyOrPatch { get; set; }

        [JsonPropertyName("total")]
        public double Total { get; set; }

        [JsonPropertyName("estimated")]
        public bool Estimated { get; set; }
    }
}