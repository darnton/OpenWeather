using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class Forecast
    {
        [JsonPropertyName("cnt")]
        public int Count { get; set; }
        public City City { get; set; }
        [JsonPropertyName("list")]
        public List<ForecastItem> Items { get; set; }

    }
}
