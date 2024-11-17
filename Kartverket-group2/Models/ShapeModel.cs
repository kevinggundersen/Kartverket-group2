using System.Text.Json.Serialization;

namespace Kartverket_group2.Models
{
    /// <summary>
    /// Represents a GeoJSON FeatureCollection containing multiple geographic features.
    /// Conforms to the GeoJSON specification.
    /// </summary>
    public class GeoJsonFeatureCollection
    {
        /// <summary>
        /// Type identifier for GeoJSON object. Always "FeatureCollection".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "FeatureCollection";

        /// <summary>
        /// Collection of geographic features.
        /// </summary>
        [JsonPropertyName("features")]
        public List<GeoJsonFeature> Features { get; set; } = new List<GeoJsonFeature>();

        /// <summary>
        /// Identifier for the currently active map tile layer.
        /// </summary>
        [JsonPropertyName("activeTileLayer")]
        public string ActiveTileLayer { get; set; } // New property
    }

    /// <summary>
    /// Represents a single geographic feature in GeoJSON format.
    /// </summary>
    public class GeoJsonFeature
    {
        /// <summary>
        /// Type identifier for GeoJSON object. Always "Feature".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "Feature";

        /// <summary>
        /// The geometric shape and coordinates of the feature.
        /// </summary>
        [JsonPropertyName("geometry")]
        public GeoJsonGeometry Geometry { get; set; }

        /// <summary>
        /// Additional properties associated with the feature.
        /// </summary>
        [JsonPropertyName("properties")]
        public GeoJsonProperties Properties { get; set; }
    }

    /// <summary>
    /// Represents the geometric aspects of a GeoJSON feature.
    /// </summary>
    public class GeoJsonGeometry
    {
        /// <summary>
        /// The type of geometry (Point, LineString, Polygon, etc.).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The coordinate array defining the shape. Type varies based on geometry type.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public object Coordinates { get; set; }
    }

    /// <summary>
    /// Contains additional attributes and metadata for a GeoJSON feature.
    /// </summary>
    public class GeoJsonProperties
    {
        /// <summary>
        /// Unique identifier for the feature.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The type of geographic feature.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// User-provided description or notes about the feature.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Timestamp when the feature was created.
        /// </summary>
        [JsonPropertyName("addedAt")]
        public string? AddedAt { get; set; }

        /// <summary>
        /// Timestamp of the most recent modification.
        /// </summary>
        [JsonPropertyName("lastEdited")]
        public string? LastEdited { get; set; }

        /// <summary>
        /// Radius in meters, if the feature is a circular shape.
        /// </summary>
        [JsonPropertyName("radius")]
        public double? Radius { get; set; }
    }
}