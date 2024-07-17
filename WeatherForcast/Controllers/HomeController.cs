using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using WeatherForcast.Models;

namespace WeatherForcast.Controllers
{
	public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, HttpClient httpClient, IConfiguration configuration)
        {
            _logger = logger;
            _httpClient = httpClient;
            _configuration = configuration;
        }

		[HttpPost]
		public async Task<IActionResult> GetCoords(string address)
		{

			string apiKey = "2d78e6107cc64cc9b858c0fefb06c2d3";

			var uri = $"https://api.geoapify.com/v1/geocode/search?text={address}&filter=countrycode:au&format=json&apiKey={apiKey}";
			var response = await _httpClient.GetAsync(uri);

			if (response.IsSuccessStatusCode)
			{
				var jsonString = await response.Content.ReadAsStringAsync();
				var jsonResult = JObject.Parse(jsonString);

				var lon = jsonResult["results"][0]["lon"].Value<double>();
				var lat = jsonResult["results"][0]["lat"].Value<double>();

				var geocodeResponse = new Models.LocationInputModel
				{
					Longitude = lon,
					Latitude = lat
				};


				return RedirectToAction("Index", geocodeResponse);
			}
			else
			{

				return BadRequest("Failed to retrieve coordinates.");
			}
		}

		public async Task<WeatherForecast> GetWeatherAsync(double latitude, double longitude)
        {
            //_configuration.GetSection(URL_STRING);
            //add string to program cs and call with ICong
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,relative_humidity_2m,precipitation,soil_temperature_10_to_35cm&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_sum&timezone=Australia%2FSydney&models=bom_access_global";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherForecast>(response);
        }
        public async Task<IActionResult> Index(LocationInputModel location)
         {
            var weatherForecast = await GetWeatherAsync(location.Latitude, location.Longitude);

            

            List<ChartData> hourlyWeatherData = weatherForecast.Hourly.Time.Select((time, index) => new ChartData
			{
                

				xValue = (time),
				yTemperature = weatherForecast.Hourly.Temperature2m[index],
				yRain = weatherForecast.Hourly.Precipitation[index] ?? 0,
				ySoilTemperature = weatherForecast.Hourly.SoilTemperature10To35cm[index] ?? 0
			}).ToList();

			ViewBag.dataSource = hourlyWeatherData;

			return View(weatherForecast);
        }
		public IActionResult Privacy()
        {
            return View();
        }

    }
}
