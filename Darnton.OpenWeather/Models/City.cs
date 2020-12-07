using System.Text.Json.Serialization;

namespace Darnton.OpenWeather.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
        public string Country { get; set; }
        [JsonPropertyName("timezone")]
        public int TimezoneOffset { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }

    }
}
