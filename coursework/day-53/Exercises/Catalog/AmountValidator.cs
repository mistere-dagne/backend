namespace AddisEats.Catalog;

public static class AmountValidator
{
    public static void ValidateAmount(decimal amount)
    {
        if (amount <= 0m)
        {
            throw new ArgumentException("Amount must be positive.");
        }
    }
}