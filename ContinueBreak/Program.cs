using System;

class Program
{
    static void Main()
    {
        int[] nums = { 15, 7, 12, 23, 41, 28, 9, 17, 32 };

        // -----------------------------
        // break example
        // -----------------------------
        Console.WriteLine("Break example:");

        foreach (int num in nums)
        {
            Console.WriteLine(num);

            if (num == 23)
            {
                Console.WriteLine("Found 23, stopping loop.");
                break;
            }
        }

        Console.WriteLine("Done with break example.");
        Console.WriteLine();

        // -----------------------------
        // continue example
        // -----------------------------
        Console.WriteLine("Continue example (skip even numbers):");

        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                continue; // skip even numbers
            }

            Console.WriteLine(num);
        }

        Console.WriteLine("Done with continue example.");
    }
}