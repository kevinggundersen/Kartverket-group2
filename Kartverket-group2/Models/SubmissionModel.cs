using System.Text.Json.Serialization;

namespace Kartverket_group2.Models
{
    public class Submission
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("geoJsonData")]
        public GeoJsonFeatureCollection GeoJsonData { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = "Uåpnet"; // Default status

        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }
    }
}