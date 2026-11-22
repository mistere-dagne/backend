using System.Linq;

namespace AddisEats.OrderBook.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = "";
    public string Area { get; set; } = "";
    public List<OrderLine> Lines { get; set; } = new();

    public decimal Total => Lines.Sum(line => line.Item.Price * line.Quantity);
}