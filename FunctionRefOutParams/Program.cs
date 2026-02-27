using System;
namespace FunctionRefOutParams
{
    public class Program
    {
        static void TestFunc1(int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"TestFunc1: {arg1}");

        }

        static void TestFunc2(ref int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        static void PlusTimes(int arg1, int arg2, out int sum, out int product)
        {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        public static void Main()
        {
            // int val1 = 10;

            // TestFunc1(val1);   // prints 20
            // Console.WriteLine(val1); // prints 10

            // TestFunc2(ref val1);  // prints 20
            // Console.WriteLine(val1); // prints 20

            int val1 = 20, val2 = 20;

            int a, b;
            PlusTimes(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");
        }


    }
}

