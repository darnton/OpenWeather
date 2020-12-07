using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class Wind
    {
        /// <summary>
        /// Wind speed in metres per second
        /// </summary>
        public decimal Speed { get; set; }
        [JsonPropertyName("deg")]
        public int Direction { get; set; }
    }
}
