using System;
public class FunctionBasics
{
    // Convert miles to kilometers
    static double MilesToKm(double Miles)
    {
        return Miles * 1.60934;
    }

    // print string with prefix
    static void PrintWithPrefix(string thestr)
    {
        Console.WriteLine($"::> {thestr}");
    }
    public static void Main()
    {
        // Calls
        Console.WriteLine($"The result is {MilesToKm(8.0):F2}");
        Console.WriteLine($"The result is {MilesToKm(52.0):F2}");

        PrintWithPrefix("Test string");
        PrintWithPrefix("Another test string");
    }
}