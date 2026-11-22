namespace AddisEats.OrderBook.Models;

public record OrderLine
{
    public MenuItem Item { get; init; }
    public int Quantity { get; init; }

    public OrderLine(MenuItem item, int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be positive.");
        }

        Item = item;
        Quantity = quantity;
    }
}