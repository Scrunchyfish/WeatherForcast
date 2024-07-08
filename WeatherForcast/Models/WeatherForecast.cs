namespace WeatherForcast.Models
{


    using Newtonsoft.Json;
    using System.Collections.Generic;

   

    public class WeatherForecast
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("generationtime_ms")]
        public double GenerationtimeMs { get; set; }

        [JsonProperty("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("daily")]
        public DailyWeather Daily { get; set; } = new DailyWeather();

        [JsonProperty("hourly")]
        public HourlyWeather Hourly { get; set; } = new HourlyWeather();
    }

    public class DailyWeather
    {
        [JsonProperty("time")]
        public List<string> Time { get; set; } = new List<string>();

        [JsonProperty("weather_code")]
        public List<int?> WeatherCode { get; set; } = new List<int?>();

        [JsonProperty("temperature_2m_max")]
        public List<double> Temperature2mMax { get; set; } = new List<double>();

        [JsonProperty("temperature_2m_min")]
        public List<double> Temperature2mMin { get; set; } = new List<double>();

        [JsonProperty("precipitation_sum")]
        public List<double> PrecipitationSum { get; set; } = new List<double>();
    }

    public class HourlyWeather
    {
        [JsonProperty("time")]
        public List<string> Time { get; set; } = new List<string>();

        [JsonProperty("temperature_2m")]
        public List<double> Temperature2m { get; set; } = new List<double>();

        [JsonProperty("relative_humidity_2m")]
        public List<int> RelativeHumidity2m { get; set; } = new List<int>();

        [JsonProperty("precipitation")]
        public List<double?> Precipitation { get; set; } = new List<double?>();

        [JsonProperty("soil_temperature_10_to_35cm")]
        public List<double> SoilTemperature10To35cm { get; set; } = new List<double>();
    }



}
