using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class MainResult
    {
        [JsonPropertyName("temp")]
        public decimal Temperature { get; set; }
        public decimal FeelsLike { get; set; }
        [JsonPropertyName("temp_min")]
        public decimal MinTemperature { get; set; }
        [JsonPropertyName("temp_max")]
        public decimal MaxTemperature { get; set; }
        public decimal Pressure { get; set; }
        public decimal Humidity { get; set; }
    }
}
