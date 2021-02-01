using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// Recent preceipitation volumes.
    /// </summary>
    public class Precipitation
    {
        /// <summary>
        /// Precipitation in the last hour, in millimetres.
        /// </summary>
        [JsonPropertyName("1h")]
        public decimal OneHourVolume { get; set; }
        /// <summary>
        /// Precipitation in the three hours, in millimetres.
        /// </summary>
        [JsonPropertyName("3h")]
        public decimal ThreeHourVolume { get; set; }
    }
}
