using Microsoft.AspNetCore.Mvc;

namespace WebApiForAiCR.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger) { _logger = logger; }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var no_reason_name = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        return no_reason_name;
    }

    private void UseLessMethod()
    {
        var a = 1;
    }
    
    private long UseLessMethod_()
    { 
        FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        fs.Dispose();
        var len = fs.Length;

        return len;
    }
    private async Task AsyncTest()
    {
        await Task.FromResult(() => { });
    }

    public async Task TastAsync()
    {
        await AsyncTest();
    }
}