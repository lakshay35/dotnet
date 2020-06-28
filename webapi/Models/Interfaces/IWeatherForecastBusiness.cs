using webapi.models.classes;
using System.Collections.Generic;

namespace webapi.models.interfaces {
  public interface IWeatherForecastBusiness {
    IEnumerable<WeatherForecast> getForecast();
  }
}