using System;
public class Program
{
    static void PrintWithPrefix(string thestr, string prefix = "")
    {
        Console.WriteLine($"{prefix} {thestr}");
    }
    public static void Main()
    {
        PrintWithPrefix("Hello Honey!");
        PrintWithPrefix("Hello Honey", ">:");

        // call with named params
        PrintWithPrefix(prefix: ">:", thestr: "Hello Honey");
    }
}