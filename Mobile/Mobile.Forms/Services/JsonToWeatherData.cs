namespace Mobile.Forms.Services
{
    using BockWeather14.Server.Models;

    using Newtonsoft.Json;

    public class JsonToWeatherData : IJsonToWeatherData
    {
        public WeatherRecord Convert(string jsonString)
        {
            return JsonConvert.DeserializeObject<WeatherRecord>(jsonString);
        }
    }
}