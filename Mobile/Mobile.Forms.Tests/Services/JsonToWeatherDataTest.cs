using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Tests.Services
{
    using BockWeather14.Server.Models;

    using FluentAssertions;

    using Mobile.Forms.Services;

    using NUnit.Framework;

    [TestFixture]
    public class JsonToWeatherDataTest
    {
        private IJsonToWeatherData testee;

        [SetUp]
        public void SetUp()
        {
            this.testee = new JsonToWeatherData();
        }

        [Test]
        public void ConvertTest()
        {
            var messageBuilder = new StringBuilder("{");
            const string StationId = "14";
            const string CityName = "Davos";
            const string TimeStamp = "1403646195";
            const string Temperature = "22.3";
            const string Pressure = "1003";
            const string Humidity = "81";

            messageBuilder
                .Append("\"StationId\":").Append(StationId).Append(",")
                .Append("\"CityName\":\"").Append(CityName).Append("\",")
                .Append("\"Timestamp\":").Append(TimeStamp).Append(",")
                .Append("\"Temperature\":").Append(Temperature).Append(",")
                .Append("\"Pressure\":").Append(Pressure).Append(",")
                .Append("\"Humidity\":").Append(Humidity)
                .Append("}");

            string message = messageBuilder.ToString();

            WeatherRecord record = this.testee.Convert(message);

            record.StationId.Should().Be(int.Parse(StationId));
            record.CityName.Should().Be(CityName);
            record.TimeStamp.Should().Be(long.Parse(TimeStamp));
            record.Temperature.Should().Be(double.Parse(Temperature));
            record.Pressure.Should().Be(double.Parse(Pressure));
            record.Humidity.Should().Be(int.Parse(Humidity));
        }
    }
}
