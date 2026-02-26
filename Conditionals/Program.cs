using System;

class Program
{
    static void Main()
    {
        string name = "Honey";
        int age = 20;

        // -----------------------------
        // If condition
        // -----------------------------
        if (age >= 18)
        {
            Console.WriteLine($"Eligible to vote, {name}!");
        }

        // -----------------------------
        // If-Else condition
        // -----------------------------
        if (name == "Honey")
        {
            Console.WriteLine($"Hello {name}!");
        }
        else
        {
            Console.WriteLine("Hello Guest!");
        }

        // -----------------------------
        // Ternary operator
        // -----------------------------
        int x = 10;
        int y = 20;

        string result = x > y
            ? "x is greater than y"
            : "x is less than or equal to y";

        Console.WriteLine($"Comparison result: {result}");

        // -----------------------------
        // Switch statement
        // -----------------------------
        int day = 14;

        Console.WriteLine("Classic switch result:");
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Invalid day"); break;
        }

        // -----------------------------
        // Modern switch expression
        // -----------------------------
        string dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };

        Console.WriteLine($"Switch expression result: {dayName}");
    }
}