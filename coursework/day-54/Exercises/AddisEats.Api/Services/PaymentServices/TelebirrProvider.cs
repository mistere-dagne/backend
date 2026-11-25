namespace AddisEats.Api.Services.PaymentServices;

public class TeleBirrProvider : IPaymentProvider
{
    public string GetProviderName()
    {
        return "TeleBirr";
    }
}