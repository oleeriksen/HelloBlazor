using System;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Return n objects of random weatherforecasts if n is less than 101.
    /// Otherwise it will return 100 random weatherforecasts
    /// </summary>
    /// <param name="n">The number of objects to be returned</param>
    [HttpGet]
    [Route("{n:int}")]
    public IEnumerable<WeatherForecast> Get(int n)
    {
        if (n > 100)
            n = 100;
        return Enumerable.Range(1, n).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

