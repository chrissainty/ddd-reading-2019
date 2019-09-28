using System;
using System.Threading.Tasks;

namespace BlazorCore.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}