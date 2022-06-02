using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Interface;

namespace PunishmentOrg.Api.Core.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var id = "011104056";
        var result1 = _unitOfWork.Unit.GetUnitWithParentUnitList(id);
        var resultGetById = _unitOfWork.Unit.GetById(1);
        var resultGetAll = _unitOfWork.Unit.GetAll();
        var resultFind = _unitOfWork.Unit.Find(x => x.TheGUnitType.Code.StartsWith("0"));

        _unitOfWork.Complete();


        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
