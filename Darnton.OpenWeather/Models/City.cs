using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// The city that a weather report or forecast applies to.
    /// </summary>
    public class City
    {
        /// <summary>
        /// The OpenWeather city ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The city name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The <see cref="Coordinates"/> of the city.
        /// </summary>
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
        /// <summary>
        /// The two-letter country code of the country the city is in. 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// The city's timezone offset from UTC in seconds.
        /// </summary>
        [JsonPropertyName("timezone")]
        public int TimezoneOffset { get; set; }
        /// <summary>
        /// The Unix timestamp of the time of sunrise in the city.
        /// </summary>
        public long Sunrise { get; set; }
        /// <summary>
        /// The Unix timestamp of the time of sunset in the city.
        /// </summary>
        public long Sunset { get; set; }

    }
}
