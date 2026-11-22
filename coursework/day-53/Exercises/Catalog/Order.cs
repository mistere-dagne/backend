namespace AddisEats.Catalog;

public class Order
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = "";

    public string Area { get; set; } = "";

    public decimal Subtotal { get; set; }

    public DateTime PlacedOn { get; set; }
}