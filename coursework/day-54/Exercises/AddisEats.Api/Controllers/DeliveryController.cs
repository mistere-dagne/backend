using AddisEats.Api.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class DeliveryController : ControllerBase
{
    private readonly DeliveryOptions _deliveryOptions;

    public DeliveryController(IOptions<DeliveryOptions> options)
    {
        _deliveryOptions = options.Value;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            freeAboveEtb = _deliveryOptions.FreeAboveEtb,
            defaultFeeEtb = _deliveryOptions.DefaultFeeEtb
        });
    }
}