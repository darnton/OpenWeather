using Darnton.OpenWeather.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Darnton.OpenWeather.Services
{
    public interface IOpenWeatherService
    {
        Task<CurrentWeather> GetCurrentWeatherAsync(int cityId, Guid appId);
        Task<Forecast> GetForecastAsync(int cityId, Guid appId);
    }
    
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly HttpClient _client;
        private const string OpenWeatherApiBaseUrl = "https://api.openweathermap.org/data/2.5/";

        public OpenWeatherService(HttpClient client)
        {
            client.BaseAddress = new Uri(OpenWeatherApiBaseUrl);
            _client = client;
        }

        public async Task<CurrentWeather> GetCurrentWeatherAsync(int cityId, Guid appId)
        {
            var url = $"weather?id={cityId}&units=metric&appid={appId:N}";
            return await _client.GetFromJsonAsync<CurrentWeather>(url);
        }

        public async Task<Forecast> GetForecastAsync(int cityId, Guid appId)
        {
            var url = $"forecast?id={cityId}&units=metric&appid={appId:N}";
            return await _client.GetFromJsonAsync<Forecast>(url);
        }
    }
}
