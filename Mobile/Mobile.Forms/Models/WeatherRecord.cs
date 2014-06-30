namespace BockWeather14.Server.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class WeatherRecord
    {
        [DataMember(Name = "StationId")]
        public int StationId { get; set; }

        [DataMember(Name = "CityName")]
        public string CityName { get; set; }

        [DataMember(Name = "Timestamp")]
        public long TimeStamp { get; set; }

        [DataMember(Name = "Temperature")]
        public double Temperature { get; set; }

        [DataMember(Name = "Pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "Humidity")]
        public int Humidity { get; set; }
    }
}