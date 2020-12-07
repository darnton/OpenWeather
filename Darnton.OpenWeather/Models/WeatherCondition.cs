namespace Darnton.OpenWeather.Models
{
    public class WeatherCondition
    {
        public WeatherConditionCode Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public enum WeatherConditionGroup
    {
        Thunderstorm = 2,
        Drizzle = 3,
        Rain = 5,
        Snow = 6,
        Atmosphere = 7,
        Clouds = 8
    }

    public enum WeatherConditionCode
    {
        ThunderstormLightRain = 200,
        ThunderstormRain = 201,
        ThunderstormHeavyRain = 202,
        LightThunderstorm = 210,
        Thunderstorm = 211,
        HeavyThunderstorm = 212,
        RaggedThunderstorm = 221,
        ThunderstormLightDrizzle = 230,
        ThunderstormDrizzle = 231,
        ThunderstormheavyDrizzle = 232,

        LightIntensityDrizzle = 300,
        Drizzle = 301,
        HeavyIntensityDrizzle = 302,
        LightIntensityDrizzleRain = 310,
        DrizzleRain = 301,
        HeavyIntensityDrizzleRain = 302,
        ShowerRainAndDrizzle = 303,
        HeavyShowerRainAndDrizzle = 304,
        ShowerDrizzle = 321,

        LightRain = 500,
        ModerateRain = 501,
        HeavyIntensityRain = 502,
        VeryHeavyRain = 503,
        ExtremeRain = 504,
        FreezingRain = 511,
        LightIntensityShowerRain = 520,
        ShowerRain = 521,
        HeavyIntensityShowerRain = 522,
        RaggedShowerRain = 531,

        LightSnow = 600,
        Snow = 600,
        HeavySnow = 600,
        Sleet = 600,
        LightShowerSleet = 600,
        ShowerSleetSnow = 600,
        LightRainAndSnow = 600,
        RainAndSnow = 600,
        LightShowerSnow = 600,
        ShowerSnow = 600,
        HeavyShowerSnow = 600,

        Mist = 701,
        Smoke = 711,
        Haze = 721,
        SandDustWhirls = 731,
        Fog = 741,
        Sand = 751,
        Dust = 761,
        VolcanicAsh = 762,
        Squalls = 771,
        Tornado = 781,

        Clear = 800,
        FewClouds = 801,
        ScatteredClouds = 802,
        BrokenClouds = 803,
        OvercastClouds = 804,
    }
}
