using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// Wind speed and direction.
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// Wind speed, in metres per second.
        /// </summary>
        public decimal Speed { get; set; }
        /// <summary>
        /// Wind direction, in degrees.
        /// </summary>
        [JsonPropertyName("deg")]
        public int Direction { get; set; }
    }
}
