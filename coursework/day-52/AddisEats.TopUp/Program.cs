
string[] customerNames = new string[5];
string[] networks = new string[5];
decimal[] amounts = new decimal[5];
decimal[] percentageBonuses = new decimal[5];
decimal[] extraBonuses = new decimal[5];
decimal[] finalCredits = new decimal[5];

decimal grandTotal = 0m;

// Collect five customer top-ups
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\nCustomer {i + 1}");

    Console.Write("Customer name: ");
    customerNames[i] = Console.ReadLine() ?? "";

    Console.Write("Network (Ethio Telecom / Safaricom): ");
    networks[i] = Console.ReadLine() ?? "";

    // Validate the top-up amount
    while (true)
    {
        Console.Write("Top-up amount in ETB: ");
        string? entry = Console.ReadLine();

        if (decimal.TryParse(entry, out decimal amount) &&
            amount > 0m &&
            amount <= 5000m)
        {
            amounts[i] = amount;
            break;
        }

        Console.WriteLine("Invalid amount. Enter an amount greater than 0 and not more than 5,000 ETB.");
    }

    // Calculate the network bonus
    decimal rate = networks[i] switch
    {
        "Ethio Telecom" => 0.05m,
        "Safaricom" => 0.03m,
        _ => 0m
    };

    percentageBonuses[i] = amounts[i] * rate;

    // Apply the additional bonus
    extraBonuses[i] = amounts[i] >= 1000m ? 20m : 0m;

    // Calculate final credit
    finalCredits[i] = amounts[i] + percentageBonuses[i] + extraBonuses[i];

    grandTotal += finalCredits[i];
}

// Print the summary
Console.WriteLine("\nTELEBIRR TOP-UP SUMMARY");

Console.WriteLine(
    $"{"Customer",-18} {"Network",-18} {"Top-up",10} {"Bonus",10} {"Extra",10} {"Credit",10}");

Console.WriteLine(new string('-', 82));

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(
        $"{customerNames[i],-18} " +
        $"{networks[i],-18} " +
        $"{amounts[i],10:N2} " +
        $"{percentageBonuses[i],10:N2} " +
        $"{extraBonuses[i],10:N2} " +
        $"{finalCredits[i],10:N2}");
}

Console.WriteLine(new string('-', 82));

Console.WriteLine(
    $"{"GRAND TOTAL",-18} {"",-18} {"",10} {"",10} {"",10} {grandTotal,10:N2}");

Console.WriteLine("\nAll five top-ups have been processed.");

