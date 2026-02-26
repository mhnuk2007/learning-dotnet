using System;

class Program
{
    static void Main()
    {
        int myVal = 15;
        int[] nums = { 3, 14, 15, 92, 6 };
        string str = "The quick brown fox jumped over the lazy dog";

        // -----------------------------
        // For loop
        // -----------------------------
        for (int i = 0; i < myVal; i++)
        {
            Console.WriteLine($"i is currently: {i}");
        }

        Console.WriteLine();

        // -----------------------------
        // Foreach loop
        // -----------------------------
        foreach (int num in nums)
        {
            Console.WriteLine($"Array value: {num}");
        }

        Console.WriteLine();

        // -----------------------------
        // Count 'o' using for loop
        // -----------------------------
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'o')
            {
                count++;
            }
        }

        Console.WriteLine($"Number of 'o' (for loop): {count}");

        // -----------------------------
        // Count 'o' using foreach loop
        // -----------------------------
        int counter = 0;

        foreach (char c in str)
        {
            if (c == 'o')
            {
                counter++;
            }
        }

        Console.WriteLine($"Number of 'o' (foreach loop): {counter}");
    }
}