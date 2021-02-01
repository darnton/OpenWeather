using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// The current weather at a location.
    /// </summary>
    public class CurrentWeather
    {
        /// <summary>
        /// The <see cref="Coordinates"/> of the location for the weather data.
        /// </summary>
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
        /// <summary>
        /// The <see cref="WeatherCondition"/>s returned for the location.
        /// </summary>
        [JsonPropertyName("weather")]
        public List<WeatherCondition> WeatherConditions { get; set; }
        /// <summary>
        /// An internal parameter.
        /// </summary>
        public string Base { get; set; }
        /// <summary>
        /// The <see cref="MainResult"/> for the current weather, containing temperature, pressure, and humidity.
        /// </summary>
        [JsonPropertyName("main")]
        public MainResult MainResult { get; set; }
        /// <summary>
        /// Visibility, in metres.
        /// </summary>
        public int Visibility { get; set; }
        /// <summary>
        /// <see cref="Wind"/> data, including speed and direction.
        /// </summary>
        public Wind Wind { get; set; }
        /// <summary>
        /// Cloud cover information.
        /// </summary>
        public Clouds Clouds { get; set; }
        /// <summary>
        /// Recent rain volume information.
        /// </summary>
        public Precipitation Rain { get; set; }
        /// <summary>
        /// Recent snow volume information.
        /// </summary>
        public Precipitation Snow { get; set; }
        /// <summary>
        /// The timestamp of the weather data, in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }
        /// <summary>
        /// A <see cref="SystemResult"/> containing local information.
        /// </summary>
        [JsonPropertyName("sys")]
        public SystemResult System { get; set; }
        /// <summary>
        /// The timezone offset of the location, from UTC, in seconds.
        /// </summary>
        [JsonPropertyName("timezone")]
        public int TimezoneOffset { get; set; }
        /// <summary>
        /// The ID of the city.
        /// </summary>
        [JsonPropertyName("id")]
        public int CityId { get; set; }
        /// <summary>
        /// The name of the city.
        /// </summary>
        [JsonPropertyName("name")]
        public string CityName { get; set; }
    }
}
