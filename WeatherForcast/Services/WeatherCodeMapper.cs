namespace WeatherForcast.Services
{
    public static class WeatherCodeMapper
    {
        public static readonly Dictionary<int, (string Description, string DayImage, string NightImage)> WeatherCodes = new()
        {
           { 0, ("Sunny", "http://openweathermap.org/img/wn/01d@2x.png", "http://openweathermap.org/img/wn/01n@2x.png") },
            { 1, ("Mainly Sunny", "http://openweathermap.org/img/wn/01d@2x.png", "http://openweathermap.org/img/wn/01n@2x.png") },
            { 2, ("Partly Cloudy", "http://openweathermap.org/img/wn/02d@2x.png", "http://openweathermap.org/img/wn/02n@2x.png") },
            { 3, ("Cloudy", "http://openweathermap.org/img/wn/03d@2x.png", "http://openweathermap.org/img/wn/03n@2x.png") },
            { 45, ("Foggy", "http://openweathermap.org/img/wn/50d@2x.png", "http://openweathermap.org/img/wn/50n@2x.png") },
            { 48, ("Rime Fog", "http://openweathermap.org/img/wn/50d@2x.png", "http://openweathermap.org/img/wn/50n@2x.png") },
            { 51, ("Light Drizzle", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 53, ("Drizzle", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 55, ("Heavy Drizzle", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 56, ("Light Freezing Drizzle", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 57, ("Freezing Drizzle", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 61, ("Light Rain", "http://openweathermap.org/img/wn/10d@2x.png", "http://openweathermap.org/img/wn/10n@2x.png") },
            { 63, ("Rain", "http://openweathermap.org/img/wn/10d@2x.png", "http://openweathermap.org/img/wn/10n@2x.png") },
            { 65, ("Heavy Rain", "http://openweathermap.org/img/wn/10d@2x.png", "http://openweathermap.org/img/wn/10n@2x.png") },
            { 66, ("Light Freezing Rain", "http://openweathermap.org/img/wn/10d@2x.png", "http://openweathermap.org/img/wn/10n@2x.png") },
            { 67, ("Freezing Rain", "http://openweathermap.org/img/wn/10d@2x.png", "http://openweathermap.org/img/wn/10n@2x.png") },
            { 71, ("Light Snow", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 73, ("Snow", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 75, ("Heavy Snow", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 77, ("Snow Grains", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 80, ("Light Showers", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 81, ("Showers", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 82, ("Heavy Showers", "http://openweathermap.org/img/wn/09d@2x.png", "http://openweathermap.org/img/wn/09n@2x.png") },
            { 85, ("Light Snow Showers", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 86, ("Snow Showers", "http://openweathermap.org/img/wn/13d@2x.png", "http://openweathermap.org/img/wn/13n@2x.png") },
            { 95, ("Thunderstorm", "http://openweathermap.org/img/wn/11d@2x.png", "http://openweathermap.org/img/wn/11n@2x.png") },
            { 96, ("Light Thunderstorms With Hail", "http://openweathermap.org/img/wn/11d@2x.png", "http://openweathermap.org/img/wn/11n@2x.png") },
            { 99, ("Thunderstorm With Hail", "http://openweathermap.org/img/wn/11d@2x.png", "http://openweathermap.org/img/wn/11n@2x.png") }
        };



    }



}


