using AddisEats.Api.Services.ClockServices; //ex-3
using Microsoft.AspNetCore.Mvc;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HealthController : ControllerBase
{
    private readonly IWebHostEnvironment _environment;
    // private readonly IClock _clock; //ex-3
    private readonly IClock _firstClock;  //ex-4
    private readonly IClock _secondClock; //

    public HealthController(IWebHostEnvironment environment,
    // IClock clock //ex-3
    IClock firstClock,
    IClock secondClock
    )
    {
        _environment = environment;
        //  _clock = clock;  //ex-3
        _firstClock = firstClock;
        _secondClock = secondClock;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            //utcTime = DateTime.UtcNow,  //ex-2
            // utcTime = _clock.GetCurrentTime(), //ex-3
            environment = _environment.EnvironmentName,
            firstTime = _firstClock.GetCurrentTime(), //ex-4
            secondTime = _secondClock.GetCurrentTime()//
           
        });
    }
}


