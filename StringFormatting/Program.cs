using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample data for formatting examples
            int[] quarters = { 1, 2, 3, 4 };
            int[] sales = { 100000, 150000, 200000, 225000 };
            double[] intlMixPct = { .386, .413, .421, .457 };

            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // =====================================================
            // BASIC STRING FORMATTING
            // =====================================================
            // {0} refers to the first argument after the format string
            Console.WriteLine("{0}", str1);
            Console.WriteLine();

            // =====================================================
            // STANDARD NUMERIC FORMAT SPECIFIERS
            // General format pattern:
            // {index[,alignment]:format}
            //
            // Common format specifiers:
            // D - Decimal (integers only)
            // N - Number (with thousands separator)
            // F - Fixed-point
            // G - General
            // E - Exponential (scientific notation)
            // P - Percent
            // X - Hexadecimal
            // C - Currency (based on system culture)
            // =====================================================

            // Formatting integer value in different styles
            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);

            // Formatting decimal value in different styles
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

            // =====================================================
            // PRECISION CONTROL
            // Adding a number after the format specifier controls precision
            // D6  -> Pad integer with leading zeros (6 digits total)
            // N2  -> 2 decimal places with thousands separator
            // F1  -> Fixed-point with 1 decimal place
            // G3  -> General format with 3 significant digits
            // =====================================================
            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);
            Console.WriteLine();

            // Individual formatting examples for clarity
            Console.WriteLine("N (Number):      {0:N}", val1);
            Console.WriteLine("N2 (Number):     {0:N2}", val2);
            Console.WriteLine("F2 (Fixed):      {0:F2}", val2);
            Console.WriteLine("G (General):     {0:G}", val2);
            Console.WriteLine("E (Exponential): {0:E}", val2);
            Console.WriteLine("D6 (Decimal):    {0:D6}", val1);
            Console.WriteLine("X (Hex):         {0:X}", val1);
            Console.WriteLine("P (Percent):     {0:P}", .386);
            Console.WriteLine("C (Currency):    {0:C}", val2);
            Console.WriteLine();

            // =====================================================
            // ADDITIONAL PRECISION EXAMPLES
            // =====================================================
            Console.WriteLine("F1: {0:F1}", val2);
            Console.WriteLine("F3: {0:F3}", val2);
            Console.WriteLine("N0: {0:N0}", val2);
            Console.WriteLine();

            // =====================================================
            // ALIGNMENT AND SPACING
            // Positive number  -> Right alignment
            // Negative number  -> Left alignment
            // The number specifies total width of the field
            // =====================================================
            Console.WriteLine("|{0,10}|", str1);   // Right aligned in 10 spaces
            Console.WriteLine("|{0,-10}|", str1);  // Left aligned in 10 spaces
            Console.WriteLine();

            // =====================================================
            // TABLE STYLE FORMATTING
            // Demonstrates alignment + formatting together
            // =====================================================
            Console.WriteLine("{0,-10} {1,15} {2,15}",
                "Quarter", "Sales", "Intl Mix");

            for (int i = 0; i < quarters.Length; i++)
            {
                Console.WriteLine("{0,-10} {1,15:C0} {2,15:P1}",
                    quarters[i],       // Quarter number
                    sales[i],          // Sales formatted as currency (no decimals)
                    intlMixPct[i]);    // Percent with 1 decimal
            }

            Console.WriteLine();
        }
    }
}