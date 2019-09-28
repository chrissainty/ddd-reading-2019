using BlazorCore.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWasm.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return _httpClient.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
