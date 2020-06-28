using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using webapi.business;
using webapi.models.classes;
using webapi.models.interfaces;
using webapi_tests.mock;

namespace webapi_tests.unit
{
  [TestFixture]
  public class WeatherForecastBusinessTests
  {
    private IWeatherForecastBusiness _weatherForecastBusiness;

    [SetUp]
    public void SetUp()
    {
      _weatherForecastBusiness = new MockWeatherForecastBusiness();
    }

    [Test]
    public void Returns5RecordsInForecast_OfTypeWeatherForecast()
    {
      IEnumerable<WeatherForecast> result = _weatherForecastBusiness.getForecast();
      IEnumerator enumerator = result.GetEnumerator();
      Assert.AreEqual(result.Count(), 10);
      Assert.IsInstanceOf(typeof(WeatherForecast), result.ToList().ElementAt(0));
    }
  }
}