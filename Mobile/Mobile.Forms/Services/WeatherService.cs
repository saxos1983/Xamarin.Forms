using System;

namespace Mobile.Forms.Services
{
    using System.Diagnostics;
    using System.Net.Http;
    using System.Threading.Tasks;

    using BockWeather14.Server.Models;

    public class WeatherService : IWeatherService
    {
        public WeatherService(IJsonToWeatherData jsonToWeatherData)
        {
            this.jsonToWeatherData = jsonToWeatherData;
        }

        private readonly IJsonToWeatherData jsonToWeatherData;

        private WeatherRecord weatherData = null;

        public async Task<WeatherRecord> GetLatestData(int id)
        {
            string url = string.Format("http://192.168.1.10:8088/WeatherRecord/{0}/", id);

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            var content = await httpClient.GetStringAsync(url).ConfigureAwait(false);
            this.weatherData = this.jsonToWeatherData.Convert(content);

            return this.weatherData;
        }
    }
}