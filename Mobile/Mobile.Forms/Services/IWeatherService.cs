namespace Mobile.Forms.Services
{
    using System.Threading.Tasks;

    using BockWeather14.Server.Models;

    public interface IWeatherService
    {
        Task<WeatherRecord> GetLatestData(int id);
    }
}