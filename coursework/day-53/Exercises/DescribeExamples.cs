public static class DescribeExamples
{
    public static void Describe(int value)
    {
        Console.WriteLine("Integer overload");
    }

    public static void Describe(string value)
    {
        Console.WriteLine("String overload");
    }

    public static void Describe(decimal value)
    {
        Console.WriteLine("Decimal overload");
    }
}