using System.Text.Json.Serialization;
using System.Text.Json;

namespace Kartverket_group2.Models
{
    public class Submission
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("geoJsonData")]
        public GeoJsonFeatureCollection GeoJsonData { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = "Ikke påbegynt"; // Default status

        [JsonPropertyName("municipalitynr")]
        public string Municipalitynr { get; set; }

        public string? UserId { get; set; }

        public string? AdminComment { get; set; } 
    }

    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string dateString = reader.GetString();
            if (DateTime.TryParse(dateString, null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime result))
            {
                return result;
            }

            // Fallback parsing for the format used in your getCurrentTimestamp function
            if (DateTime.TryParseExact(dateString,
                "yyyy-MM-dd HH:mm:ss",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out result))
            {
                return result;
            }

            throw new JsonException($"Unable to parse datetime: {dateString}");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("o")); // ISO 8601 format
        }
    }
}