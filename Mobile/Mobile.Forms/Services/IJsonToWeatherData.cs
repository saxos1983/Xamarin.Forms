using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Services
{
    using BockWeather14.Server.Models;

    public interface IJsonToWeatherData
    {
        WeatherRecord Convert(string jsonString);
    }
}
