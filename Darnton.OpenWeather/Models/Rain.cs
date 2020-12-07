using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class Precipitation
    {
        [JsonPropertyName("1h")]
        public decimal OneHourVolume { get; set; }
        [JsonPropertyName("3h")]
        public decimal ThreeHourVolume { get; set; }
    }
}
