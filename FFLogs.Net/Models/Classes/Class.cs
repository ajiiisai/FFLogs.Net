using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Classes
{
    public class Class
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("specs")]
        public Job[] Jobs { get; set; }
    }

    public class Job
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}