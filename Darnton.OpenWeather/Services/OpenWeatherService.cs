using Darnton.OpenWeather.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Darnton.OpenWeather.Services
{
    /// <summary>
    /// Provides access to the Open Weather API.
    /// <see href="https://openweathermap.org/api"/>
    /// </summary>
    public interface IOpenWeatherService
    {
        /// <summary>
        /// Gets the <see cref="CurrentWeather"/> for a given city from the OpenWeather current weather endpoint.
        /// <see href="https://openweathermap.org/current"/>
        /// </summary>
        /// <param name="cityId">The OpenWeather city ID.</param>
        /// <param name="appId">The OpenWeather API key. Unique per user account.</param>
        /// <returns>The <see cref="CurrentWeather"/>.</returns>
        Task<CurrentWeather> GetCurrentWeatherAsync(int cityId, Guid appId);
        /// <summary>
        /// Gets the 5-day weather <see cref="Forecast"/> for a given city from the OpenWeather forecast endpoint.
        /// <see href="https://openweathermap.org/forecast5"/>
        /// </summary>
        /// <param name="cityId">The OpenWeather city ID.</param>
        /// <param name="appId">The OpenWeather API key. Unique per user account.</param>
        /// <returns>The weather <see cref="Forecast"/></returns>
        Task<Forecast> GetForecastAsync(int cityId, Guid appId);
    }
    

    /// <inheritdoc/>
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly HttpClient _client;
        private const string OpenWeatherApiBaseUrl = "https://api.openweathermap.org/data/2.5/";

        /// <summary>
        /// Constructs an OpenWeatherService instance.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> used to connect to the OpenWeather API.</param>
        public OpenWeatherService(HttpClient client)
        {
            client.BaseAddress = new Uri(OpenWeatherApiBaseUrl);
            _client = client;
        }

        /// <inheritdoc/>
        public async Task<CurrentWeather> GetCurrentWeatherAsync(int cityId, Guid appId)
        {
            var url = $"weather?id={cityId}&units=metric&appid={appId:N}";
            return await _client.GetFromJsonAsync<CurrentWeather>(url);
        }

        /// <inheritdoc/>
        public async Task<Forecast> GetForecastAsync(int cityId, Guid appId)
        {
            var url = $"forecast?id={cityId}&units=metric&appid={appId:N}";
            return await _client.GetFromJsonAsync<Forecast>(url);
        }
    }
}
