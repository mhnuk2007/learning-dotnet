using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
            string a = "abcd", b = "efgh";

            // -----------------------------
            // Basic Math Operators
            // -----------------------------
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} % {y} = {x % y}");
            Console.WriteLine($"String Concatenation: {a} + {b} = {a + b}");
            Console.WriteLine();

            // -----------------------------
            // Increment / Decrement
            // -----------------------------
            Console.WriteLine("----- Increment / Decrement -----");

            Console.WriteLine($"Original x: {x}");
            Console.WriteLine($"Pre-increment (++x): {++x}");
            Console.WriteLine($"After pre-increment x: {x}");
            Console.WriteLine($"Post-increment (x++): {x++}");
            Console.WriteLine($"After post-increment x: {x}");
            Console.WriteLine();

            Console.WriteLine($"Original y: {y}");
            Console.WriteLine($"Pre-decrement (--y): {--y}");
            Console.WriteLine($"After pre-decrement y: {y}");
            Console.WriteLine($"Post-decrement (y--): {y--}");
            Console.WriteLine($"After post-decrement y: {y}");
            Console.WriteLine();

            // -----------------------------
            // Shorthand Operators
            // -----------------------------
            Console.WriteLine("----- Shorthand Assignment -----");
            a += b;
            Console.WriteLine($"a += b → {a}");
            Console.WriteLine();

            // -----------------------------
            // Comparison Operators
            // -----------------------------
            Console.WriteLine("----- Comparison Operators -----");
            Console.WriteLine($"x == y : {x == y}");
            Console.WriteLine($"x != y : {x != y}");
            Console.WriteLine($"x > y  : {x > y}");
            Console.WriteLine($"x < y  : {x < y}");
            Console.WriteLine($"x >= y : {x >= y}");
            Console.WriteLine($"x <= y : {x <= y}");
            Console.WriteLine();

            // -----------------------------
            // Logical Operators
            // -----------------------------
            Console.WriteLine("----- Logical Operators -----");
            Console.WriteLine($"x > y && y >= 5 : {x > y && y >= 5}");
            Console.WriteLine($"x > y || y >= 5 : {x > y || y >= 5}");
            Console.WriteLine($"!(x > y) : {!(x > y)}");
            Console.WriteLine();

            // -----------------------------
            // Ternary Operator
            // -----------------------------
            Console.WriteLine("----- Ternary Operator -----");
            string comparison = x > y ? "x is greater than y" : "y is greater or equal to x";
            Console.WriteLine(comparison);
            Console.WriteLine();

            // -----------------------------
            // Null-Coalescing Operators
            // -----------------------------
            Console.WriteLine("----- Null-Coalescing Operators -----");

            string? str = null;

            Console.WriteLine($"Using ?? : {str ?? "Unknown string"}");

            str ??= "New string";
            Console.WriteLine($"After ??= assignment: {str}");
        }
    }
}