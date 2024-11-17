using System.Text.Json.Serialization;
using System.Text.Json;

/// <summary>
/// Represents a user's submission containing geographic data and metadata.
/// </summary>
namespace Kartverket_group2.Models
{
    public class Submission
    {
        /// <summary>
        /// Unique identifier for the submission.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// User's comments or description about the submission.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Timestamp when the submission was created.
        /// Uses a custom converter for flexible date format parsing.
        /// </summary>
        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Collection of geographic features included in the submission.
        /// </summary>
        [JsonPropertyName("geoJsonData")]
        public GeoJsonFeatureCollection GeoJsonData { get; set; }

        /// <summary>
        /// Current status of the submission.
        /// Defaults to "Ikke påbegynt" (Not Started).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = "Ikke påbegynt"; // Default status

        /// <summary>
        /// Municipality number identifying the relevant administrative area.
        /// </summary>
        [JsonPropertyName("municipalitynr")]
        public string Municipalitynr { get; set; }

        /// <summary>
        /// Identifier of the user who created the submission.
        /// Can be null for anonymous submissions.
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// Comments added by administrators during review.
        /// Can be null if no admin has reviewed the submission.
        /// </summary>
        public string? AdminComment { get; set; } 
    }

    /// <summary>
    /// Custom JSON converter for handling different DateTime formats.
    /// Supports both ISO 8601 and custom "yyyy-MM-dd HH:mm:ss" formats.
    /// </summary>
    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        /// <summary>
        /// Converts a JSON string to a DateTime object.
        /// Attempts multiple parsing strategies for flexibility.
        /// </summary>
        /// <param name="reader">The JSON reader.</param>
        /// <param name="typeToConvert">The type to convert to (DateTime).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A DateTime object representing the parsed date.</returns>
        /// <exception cref="JsonException">Thrown when the date string cannot be parsed.</exception>
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

        /// <summary>
        /// Converts a DateTime object to its JSON string representation.
        /// Uses ISO 8601 format for maximum compatibility.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The DateTime value to convert.</param>
        /// <param name="options">Serialization options.</param>
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("o")); // ISO 8601 format
        }
    }
}