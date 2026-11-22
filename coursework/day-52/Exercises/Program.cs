
// Exercise 2: Print name, date and course information

Console.WriteLine("Mistere Dagne");
Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy"));
Console.WriteLine("CodeOps Module 4 — .NET track");


// Exercise 3: Declare and print primitive types

int orderCount = 12;
long totalViews = 9000000000L;
decimal orderTotal = 1480.50m;
double latitude = 9.0192;
bool isOpen = true;
char grade = 'A';
string restaurantName = "Yod Abyssinia";
DateTime createdAt = DateTime.Now;

Console.WriteLine($"int: {orderCount}");
Console.WriteLine($"long: {totalViews}");
Console.WriteLine($"decimal: {orderTotal}");
Console.WriteLine($"double: {latitude}");
Console.WriteLine($"bool: {isOpen}");
Console.WriteLine($"char: {grade}");
Console.WriteLine($"string: {restaurantName}");
Console.WriteLine($"DateTime: {createdAt}");


// Exercise 4: Print a formatted receipt

decimal subtotal = 1480.5m;
decimal deliveryFee = 60m;
decimal receiptTotal = subtotal + deliveryFee;

Console.WriteLine($"Subtotal  {subtotal,10:N2} ETB");
Console.WriteLine($"Delivery  {deliveryFee,10:N2} ETB");
Console.WriteLine($"Total     {receiptTotal,10:N2} ETB");


// Exercise 5: Demonstrate integer and decimal division

int integerResult = 7 / 2;
decimal decimalResult = (decimal)7 / 2;

Console.WriteLine($"Integer division: {integerResult}");
Console.WriteLine($"Decimal division: {decimalResult}");

// Decimal is better for splitting a delivery fee because it keeps fractional amounts.


// Exercise 6: Demonstrate value types and reference types

int firstNumber = 120;
int secondNumber = firstNumber;

secondNumber = 140;

Console.WriteLine($"First integer: {firstNumber}");
Console.WriteLine($"Second integer: {secondNumber}");

List<string> list1 = new List<string> { "Bole" };
List<string> list2 = list1;

list2.Add("Piassa");

Console.WriteLine($"First list: {string.Join(", ", list1)}");
Console.WriteLine($"Second list: {string.Join(", ", list2)}");

// Integers copy their values. Lists copy their references, so both variables refer to the same list.


// Exercise 7: Handle a nullable string

string? deliveryNote = null;

// Explicit null check
if (deliveryNote != null)
{
    Console.WriteLine($"Length with null check: {deliveryNote.Length}");
}
else
{
    Console.WriteLine("Length with null check: 0");
}

// Null-coalescing operator
int lengthWithFallback = deliveryNote?.Length ?? 0;
Console.WriteLine($"Length with ??: {lengthWithFallback}");

// Null-conditional operator
int? lengthWithConditional = deliveryNote?.Length;
Console.WriteLine($"Length with ?.: {lengthWithConditional}");


// Exercise 8: Safely parse an ETB amount

Console.Write("Enter an amount in ETB: ");
string? entry = Console.ReadLine();

if (decimal.TryParse(entry, out decimal amount) && amount > 0m)
{
    Console.WriteLine($"Amount: {amount:N2} ETB");
}
else
{
    Console.WriteLine("Invalid amount. Enter a number greater than zero.");
}

