namespace Darnton.OpenWeather.Models
{
    /// <summary>
    /// Container object for information about a location.
    /// </summary>
    public class SystemResult
    {
        /// <summary>
        /// The country code of the location.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Time of sunrise at the location.
        /// </summary>
        public long Sunrise { get; set; }
        /// <summary>
        /// Time of sunset at the location.
        /// </summary>
        public long Sunset { get; set; }
    }
}
