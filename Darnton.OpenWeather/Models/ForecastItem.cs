using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// A forecast for a point in time.
    /// </summary>
    public class ForecastItem
    {
        /// <summary>
        /// The timestamp of the forecast item, in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }
        /// <summary>
        /// The <see cref="MainResult"/> for the forecast item, containing temperature, pressure, and humidity.
        /// </summary>
        [JsonPropertyName("main")]
        public MainResult MainResult { get; set; }
        /// <summary>
        /// The <see cref="WeatherCondition"/>s forecast for the location.
        /// </summary>
        [JsonPropertyName("weather")]
        public List<WeatherCondition> WeatherConditions { get; set; }
        /// <summary>
        /// Forecast <see cref="Wind"/> data, including speed and direction.
        /// </summary>
        public Wind Wind { get; set; }
        /// <summary>
        /// Forecast cloud cover information.
        /// </summary>
        public Clouds Clouds { get; set; }
        /// <summary>
        /// Forecast rain volume information.
        /// </summary>
        public Precipitation Rain { get; set; }
        /// <summary>
        /// Forecast snow volume information.
        /// </summary>
        public Precipitation Snow { get; set; }
    }
}
