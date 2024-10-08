using System.Text.Json.Serialization;

namespace Kartverket_group2.Models
{
    public class GeoJsonFeatureCollection
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "FeatureCollection";

        [JsonPropertyName("features")]
        public List<GeoJsonFeature> Features { get; set; } = new List<GeoJsonFeature>();
    }

    public class GeoJsonFeature
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "Feature";

        [JsonPropertyName("geometry")]
        public GeoJsonGeometry Geometry { get; set; }

        [JsonPropertyName("properties")]
        public GeoJsonProperties Properties { get; set; }
    }

    public class GeoJsonGeometry
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public object Coordinates { get; set; }
    }

    public class GeoJsonProperties
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("addedAt")]
        public string AddedAt { get; set; }

        [JsonPropertyName("lastEdited")]
        public string LastEdited { get; set; }

        [JsonPropertyName("radius")]
        public double? Radius { get; set; }
    }
}