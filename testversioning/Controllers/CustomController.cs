using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testversioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2")]
    [ApiExplorerSettings(GroupName = "v2")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomController> _logger;

        public CustomController(ILogger<CustomController> logger)
        {
            _logger = logger;
        }
        [HttpGet]         
        public IEnumerable<WeatherForecast> Getversiondata()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
