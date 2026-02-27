using System;

namespace FunctionMultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            (int a, int b) tup1 = (5, 10);
            var tup2 = (text: "Some text", number: 10.5);

            tup1.b = 20;
            tup2.text = "New String";

            Console.WriteLine($"{tup1.a},{tup1.b}");
            Console.WriteLine($"{tup2.text},{tup2.number}");

            var result = PlusTimes(6, 12);
            Console.WriteLine($"Sum: {result.sum}, Product: {result.product}");
        }

        static (int sum, int product) PlusTimes(int a, int b)
        {
            return (a + b, a * b);
        }
    }
}