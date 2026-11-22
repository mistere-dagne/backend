using AddisEats.Catalog;

public class Program
{
    public static void Main()
    {
        // Exercise 1
        Console.WriteLine(DeliveryFee("Bole", false));
        Console.WriteLine(DeliveryFee("Piassa", isVip: true));
        Console.WriteLine(DeliveryFee("Kazanchis"));

        // Exercise 2
        DescribeExamples.Describe(25);
        DescribeExamples.Describe("Bole");
        DescribeExamples.Describe(250.50m);

        // Exercise 3
        var restaurant = new Restaurant
        {
            Id = 1,
            Name = "Habesha Restaurant",
            Area = "Bole"
        };

        Console.WriteLine(restaurant.DisplayName);
        restaurant.Name = "New Habesha Restaurant";
        Console.WriteLine(restaurant.DisplayName);

        // Exercise 4
        var customer1 = new Customer("Almaz", "0912345678");
        var customer2 = new Customer("Almaz", "0912345678");

        Console.WriteLine(customer1 == customer2);

        var classCustomer1 = new CustomerClass("Almaz", "0912345678");
        var classCustomer2 = new CustomerClass("Almaz", "0912345678");

        Console.WriteLine(classCustomer1 == classCustomer2);

        // Exercise 5
        var orders = new List<Order>
        {
            new Order { Id = 1, CustomerName = "Almaz", Area = "Bole", Subtotal = 600m, PlacedOn = DateTime.Now.AddDays(-1) },
            new Order { Id = 2, CustomerName = "Dawit", Area = "Kazanchis", Subtotal = 450m, PlacedOn = DateTime.Now.AddDays(-2) },
            new Order { Id = 3, CustomerName = "Sara", Area = "Bole", Subtotal = 350m, PlacedOn = DateTime.Now.AddDays(-3) },
            new Order { Id = 4, CustomerName = "Meron", Area = "Kazanchis", Subtotal = 700m, PlacedOn = DateTime.Now.AddDays(-4) },
            new Order { Id = 5, CustomerName = "Abel", Area = "Piassa", Subtotal = 250m, PlacedOn = DateTime.Now.AddDays(-5) }
        };

        var boleOrders = orders
            .Where(o => o.Area == "Bole" && o.Subtotal > 500m)
            .ToList();

        var customerNames = orders
            .Select(o => o.CustomerName)
            .OrderBy(name => name)
            .ToList();

        decimal kazanchisRevenue = orders
            .Where(o => o.Area == "Kazanchis")
            .Sum(o => o.Subtotal);

        var page3 = orders
            .OrderByDescending(o => o.PlacedOn)
            .Skip(20)
            .Take(10)
            .ToList();

        Console.WriteLine($"Bole orders over 500: {boleOrders.Count}");
        Console.WriteLine(string.Join(", ", customerNames));
        Console.WriteLine($"Kazanchis revenue: {kazanchisRevenue} ETB");
        Console.WriteLine($"Page 3 orders: {page3.Count}");

        // Exercise 6
        Console.WriteLine(ApplyDiscount(new TenPercentDiscount(), 500m));
        Console.WriteLine(ApplyDiscount(new FiftyBirrDiscount(), 500m));
        Console.WriteLine(ApplyDiscount(new TwentyPercentDiscount(), 500m));

        // Exercise 7
        try
        {
            AmountValidator.ValidateAmount(100m);
            Console.WriteLine("Valid amount.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally ran (valid).");
        }

        try
        {
            AmountValidator.ValidateAmount(0m);
            Console.WriteLine("Valid amount.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally ran (invalid).");
        }
    }

    public static decimal DeliveryFee(string area, bool isVip = false)
    {
        if (isVip)
            return 0m;

        return area switch
        {
            "Bole" => 50m,
            "Piassa" => 65m,
            "Kazanchis" => 60m,
            _ => 80m
        };
    }

    public static decimal ApplyDiscount(IDiscountPolicy policy, decimal amount)
    {
        return policy.Apply(amount);
    }
}
