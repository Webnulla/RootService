using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RootServiceNamespace;
using SampleService.Service.Client;

namespace SampleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRootServiceClient _rootServiceClient;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IRootServiceClient rootServiceClient)
        {
            _logger = logger;
            _rootServiceClient = rootServiceClient;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get() => await _rootServiceClient.Get();
    }
}
