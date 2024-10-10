using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Kartverket_group2.Services
{
    public class KartverketApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<KartverketApiService> _logger;
        private const string BaseUrl = "https://api.kartverket.no/kommuneinfo/v1/punkt";

        public KartverketApiService(HttpClient httpClient, ILogger<KartverketApiService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<string> GetMunicipalityAsync(double longitude, double latitude)
        {
            // Ensure coordinates are correctly formatted
            var formattedLongitude = longitude.ToString(System.Globalization.CultureInfo.InvariantCulture);
            var formattedLatitude = latitude.ToString(System.Globalization.CultureInfo.InvariantCulture);

            // The API expects coordinates in EUREF89 UTM zone 33N (EPSG:25833)
            // You might need to convert your coordinates if they're not in this system
            var url = $"{BaseUrl}?nord={formattedLatitude}&ost={formattedLongitude}&koordsys=4258";
            _logger.LogInformation("Requesting URL: {Url}", url);
            var response = await _httpClient.GetAsync(url);

            _logger.LogInformation("Requesting URL: {Url}", url);

            if (response == null)
            {
                _logger.LogError("Response is null for URL: {Url}", url);
                throw new HttpRequestException("Response is null");
            }

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("API request failed with status code {StatusCode}. Error: {ErrorContent}", response.StatusCode, errorContent);
                throw new HttpRequestException($"API request failed with status code {response.StatusCode}. Error: {errorContent}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(content);

            if (jsonDocument.RootElement.TryGetProperty("kommunenavn", out var kommunenavnElement) && kommunenavnElement.ValueKind == JsonValueKind.String)
            {
                return kommunenavnElement.GetString();
            }

            _logger.LogError("Property 'kommunenavn' not found or is not a string in the response.");
            throw new JsonException("Property 'kommunenavn' not found or is not a string in the response.");
        }
    }
}