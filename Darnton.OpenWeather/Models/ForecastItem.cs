using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class ForecastItem
    {
        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }
        [JsonPropertyName("main")]
        public MainResult MainResult { get; set; }
        [JsonPropertyName("weather")]
        public List<WeatherCondition> WeatherConditions { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Precipitation Rain { get; set; }
        public Precipitation Snow { get; set; }
    }
}
