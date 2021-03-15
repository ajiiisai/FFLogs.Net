using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Zones
{
    public partial class Zone
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("frozen")] public bool Frozen { get; set; }

        [JsonPropertyName("encounters")] public Encounter[] Encounters { get; set; }

        [JsonPropertyName("brackets")] public Bracket Brackets { get; set; }

        [JsonPropertyName("partitions")] public Partition[] Partitions { get; set; }
    }

    public partial class Encounter
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
    }
    
    public partial class Bracket
    {
        [JsonPropertyName("min")] public double Min { get; set; }
        [JsonPropertyName("max")] public double Max { get; set; }
        [JsonPropertyName("bucket")] public double Bucket { get; set; }
        [JsonPropertyName("type")] public string Type { get; set; }
    }

    public partial class Partition
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("compact")] public string Compact { get; set; }
        [JsonPropertyName("area")] public int Area { get; set; }
        [JsonPropertyName("default")] public bool? Default { get; set; }
    }
}