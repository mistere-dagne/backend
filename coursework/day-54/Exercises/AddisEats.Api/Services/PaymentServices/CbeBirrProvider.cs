namespace AddisEats.Api.Services.PaymentServices;

public class CbeBirrProvider : IPaymentProvider
{
    public string GetProviderName()
    {
        return "CBE Birr";
    }
}