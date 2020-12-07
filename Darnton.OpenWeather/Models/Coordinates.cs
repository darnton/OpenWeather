using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class Coordinates
    {
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
    }
}
