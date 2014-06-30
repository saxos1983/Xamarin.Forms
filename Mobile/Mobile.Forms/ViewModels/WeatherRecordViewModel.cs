using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.ViewModels
{
    using BockWeather14.Server.Models;

    public class WeatherRecordViewModel
    {
        public WeatherRecordViewModel()
        {
            ////this.WeatherRecord = new WeatherRecord
            ////                         {
            ////                             CityName = "Davos",
            ////                             Humidity = 81,
            ////                             Pressure = 1003,
            ////                             StationId = 1234,
            ////                             Temperature = 22.3,
            ////                             TimeStamp = 1403646195
            ////                         };
        }

        public WeatherRecord WeatherRecord { get; set; }
    }
}
