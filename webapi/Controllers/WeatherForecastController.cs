using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.models.classes;
using webapi.models.interfaces;

namespace webapi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastBusiness _weatherForecastBusiness;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastBusiness weatherForecastBusiness)
    {
      _logger = logger;
      _weatherForecastBusiness = weatherForecastBusiness;
    }

    [HttpGet]
    [Route("forecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      return _weatherForecastBusiness.getForecast();
    }
  }
}
