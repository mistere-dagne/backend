using AddisEats.OrderBook.Models;
using AddisEats.OrderBook.Services;

public class Program
{
    public static void Main()
    {
        var menu = new List<MenuItem>
        {
            new MenuItem(1, "Doro Wot", "Traditional", 450m),
            new MenuItem(2, "Shiro", "Traditional", 180m),
            new MenuItem(3, "Pasta", "Pasta", 250m),
            new MenuItem(4, "Burger", "Fast Food", 300m),
            new MenuItem(5, "Pizza", "Fast Food", 400m)
        };

        var orderBook = new OrderBook();

        var order1 = new Order
        {
            Id = 1,
            CustomerName = "Almaz",
            Area = "Bole",
            Lines = new List<OrderLine>
            {
                new OrderLine(menu[0], 2),
                new OrderLine(menu[1], 1)
            }
        };

        var order2 = new Order
        {
            Id = 2,
            CustomerName = "Dawit",
            Area = "Kazanchis",
            Lines = new List<OrderLine>
            {
                new OrderLine(menu[2], 2),
                new OrderLine(menu[3], 1)
            }
        };

        var order3 = new Order
        {
            Id = 3,
            CustomerName = "Sara",
            Area = "Bole",
            Lines = new List<OrderLine>
            {
                new OrderLine(menu[4], 2)
            }
        };

        orderBook.AddOrder(order1);
        orderBook.AddOrder(order2);
        orderBook.AddOrder(order3);

        Console.WriteLine("ADDIS EATS ORDER BOOK");
        Console.WriteLine("--------------------");

        Console.WriteLine($"Order 1 total: {order1.Total} ETB");
        Console.WriteLine($"Order 2 total: {order2.Total} ETB");
        Console.WriteLine($"Order 3 total: {order3.Total} ETB");

        Console.WriteLine();
        Console.WriteLine("Bole orders:");

        var boleOrders = orderBook.GetOrdersByArea("Bole");

        boleOrders.ForEach(order =>
            Console.WriteLine($"{order.CustomerName}: {order.Total} ETB"));

        Console.WriteLine();
        Console.WriteLine($"Total revenue: {orderBook.GetTotalRevenue()} ETB");
        Console.WriteLine($"Busiest category: {orderBook.GetBusiestCategory()}");

        Console.WriteLine();
        Console.WriteLine("Page 1:");

        var page = orderBook.GetPage(1);

        page.ForEach(order =>
            Console.WriteLine($"{order.Id}. {order.CustomerName}"));

    }
}
