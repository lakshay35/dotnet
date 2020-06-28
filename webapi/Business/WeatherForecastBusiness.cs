using webapi.models.interfaces;
using System.Collections.Generic;
using webapi.models.classes;
using System;
using System.Linq;

namespace webapi.business
{
  public class WeatherForecastBusiness : IWeatherForecastBusiness
  {

    private readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    public IEnumerable<WeatherForecast> getForecast()
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