using AddisEats.Api.Services.PaymentServices;
using Microsoft.AspNetCore.Mvc;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentProvider _paymentProvider;

    public PaymentController(IPaymentProvider paymentProvider)
    {
        _paymentProvider = paymentProvider;
    }

    [HttpGet]
    public IActionResult GetProvider()
    {
        return Ok(new
        {
            provider = _paymentProvider.GetProviderName()
        });
    }
}