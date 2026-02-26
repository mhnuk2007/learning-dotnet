using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // =====================================================
            // SAMPLE DATA
            // =====================================================
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;     // Underscore improves readability
            decimal price = 60_275.0m;

            // =====================================================
            // TRADITIONAL COMPOSITE FORMATTING
            // {index[,alignment]:format}
            // =====================================================
            Console.WriteLine(
                "This car is a {0} {1} {2}, with {3:N2} miles and costs {4:C}",
                year, make, model, miles, price);

            Console.WriteLine();

            // =====================================================
            // STRING INTERPOLATION (Modern & Preferred)
            // Uses $ prefix and inline expressions
            // =====================================================
            Console.WriteLine(
                $"This car is a {year} {make} {model}, " +
                $"with {miles:N2} miles and costs {price:C2}");

            Console.WriteLine();

            // =====================================================
            // ESCAPING BRACES IN INTERPOLATION
            // Use double braces {{ }} to print literal braces
            // =====================================================
            Console.WriteLine(
                $"Model displayed with braces: {{{model}}}");

            Console.WriteLine();

            // =====================================================
            // INLINE EXPRESSIONS INSIDE INTERPOLATION
            // Any valid C# expression can be evaluated
            // =====================================================
            Console.WriteLine(
                $"Mileage in kilometers: {miles * 1.60934:F2} km");

            Console.WriteLine(
                $"Price after 10% tax: {(price * 1.10m):C2}");

            Console.WriteLine();

            // =====================================================
            // ALIGNMENT WITH INTERPOLATION
            // Positive value  -> right align
            // Negative value  -> left align
            // =====================================================
            Console.WriteLine($"{ "Year",-6} { "Make",-15} { "Price",10}");
            Console.WriteLine($"{ year,-6} { make,-15} { price,10:C0}");
        }
    }
}