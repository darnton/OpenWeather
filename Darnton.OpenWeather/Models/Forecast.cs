using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// The forecast weather for a location.
    /// </summary>
    public class Forecast
    {
        /// <summary>
        /// The number of <see cref="ForecastItem"/>s returned in the forecast.
        /// </summary>
        [JsonPropertyName("cnt")]
        public int Count { get; set; }
        /// <summary>
        /// The <see cref="City"/> the forecast applies to.
        /// </summary>
        public City City { get; set; }
        /// <summary>
        /// A collection of <see cref="ForecastItem"/>s for the location.
        /// </summary>
        [JsonPropertyName("list")]
        public List<ForecastItem> Items { get; set; }

    }
}
