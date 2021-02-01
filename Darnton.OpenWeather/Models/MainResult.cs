using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// A container object for weather data, holding temperature, pressure, and humidity information.
    /// </summary>
    public class MainResult
    {
        /// <summary>
        /// The temperature, in units specified in the query.
        /// </summary>
        [JsonPropertyName("temp")]
        public decimal Temperature { get; set; }
        /// <summary>
        /// The temperature, in units specified in the query,
        /// adjusted for human perception.
        /// </summary>
        public decimal FeelsLike { get; set; }
        /// <summary>
        /// The minimum temperature observed in an area.
        /// </summary>
        [JsonPropertyName("temp_min")]
        public decimal MinTemperature { get; set; }
        /// <summary>
        /// The maximum temperature observed in an area.
        /// </summary>
        [JsonPropertyName("temp_max")]
        public decimal MaxTemperature { get; set; }
        /// <summary>
        /// Pressure, in hectopascals.
        /// </summary>
        public decimal Pressure { get; set; }
        /// <summary>
        /// Percentage humidity.
        /// </summary>
        public decimal Humidity { get; set; }
    }
}
