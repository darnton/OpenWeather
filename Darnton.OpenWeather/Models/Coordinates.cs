using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// The coordinates of a location.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Longitude, in degrees.
        /// </summary>
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
        /// <summary>
        /// Latitude, in degrees.
        /// </summary>
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
    }
}
