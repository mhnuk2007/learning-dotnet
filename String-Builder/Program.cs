using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // =====================================================
            // CREATE STRINGBUILDER
            // Constructor arguments:
            // 1) Initial string
            // 2) Initial capacity (maximum size before resizing)
            // =====================================================
            StringBuilder sb = new StringBuilder("Initial String. ", 200);

            int jumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };

            // Display initial state
            Console.WriteLine("===== INITIAL STATE =====");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"Length:   {sb.Length}");
            Console.WriteLine();

            // =====================================================
            // APPEND
            // Adds text to the end of the builder
            // =====================================================
            sb.Append("The quick brown fox ");
            sb.Append("jumps over the lazy dog.");

            // AppendLine adds text + newline
            sb.AppendLine();

            // AppendFormat works like Console.WriteLine formatting
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine();

            // AppendJoin joins a collection with a separator
            sb.Append("He also jumped over ");
            sb.AppendJoin(", ", animals);
            sb.AppendLine();

            // =====================================================
            // REPLACE
            // Replaces all occurrences of a substring
            // =====================================================
            sb.Replace("fox", "cat");

            // =====================================================
            // INSERT
            // Inserts text at a specific index
            // =====================================================
            sb.Insert(0, "This is the ");

            // =====================================================
            // REMOVE
            // Removes characters starting at index with given length
            // =====================================================
            sb.Remove(0, 8);  // Remove "This is "

            // =====================================================
            // CLEAR
            // Removes all content (optional demonstration)
            // Uncomment to test:
            // sb.Clear();
            // =====================================================

            // Display final state
            Console.WriteLine("===== FINAL STATE =====");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"Length:   {sb.Length}");
            Console.WriteLine();

            // Convert to string (important step)
            string finalString = sb.ToString();

            Console.WriteLine("===== FINAL OUTPUT =====");
            Console.WriteLine(finalString);
        }
    }
}