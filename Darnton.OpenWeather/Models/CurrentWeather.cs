using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class CurrentWeather
    {
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
        [JsonPropertyName("weather")]
        public List<WeatherCondition> WeatherConditions { get; set; }
        public string Base { get; set; }
        [JsonPropertyName("main")]
        public MainResult MainResult { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Precipitation Rain { get; set; }
        public Precipitation Snow { get; set; }
        [JsonPropertyName("dt")]
        public long Timestamp { get; set; }
        [JsonPropertyName("sys")]
        public SystemResult System { get; set; }
        [JsonPropertyName("timezone")]
        public int TimezoneOffset { get; set; }
        [JsonPropertyName("id")]
        public int CityId { get; set; }
        [JsonPropertyName("name")]
        public string CityName { get; set; }
    }
}
