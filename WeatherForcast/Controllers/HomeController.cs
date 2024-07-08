using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Diagnostics;
using WeatherForcast.Models;

namespace WeatherForcast.Controllers
{
    public class HomeController : Controller
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

        public async Task<WeatherForecast> GetWeatherAsync(double latitude, double longitude)
        {
            //_configuration.GetSection(URL_STRING);
            //add string to program cs and call with ICong
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_sum&timezone=Australia%2FSydney&models=bom_access_global";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherForecast>(response);
        }
        public async Task<IActionResult> Index()
        {
            var weatherForecast = await GetWeatherAsync(-34.9287, 138.5986);
            return View(weatherForecast);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
