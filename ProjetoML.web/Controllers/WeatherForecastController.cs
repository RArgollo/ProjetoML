using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
namespace ProjetoML.web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MLContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet("Banco de dados")]
    public IActionResult GetTeste(int Id)
    {
        var usuarios = _context.Usuarios.Find(Id);
        return Ok(usuarios);
    }

    [HttpGet("Other/{id}")]
    public IActionResult GetTeste2(int id)
    {
        var usuarios = _context.Usuarios.Update;
        return Ok(usuarios);
    }
}
