using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample numeric strings
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            Console.WriteLine("===== USING PARSE (Throws Exception on Failure) =====");

            try
            {
                // Basic integer parsing
                int result1 = int.Parse(numStr1);
                Console.WriteLine($"Parsed int: {result1}");

                // Parsing with decimal requires Float style
                // But int.Parse will still fail if decimal part is non-zero
                int result2 = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"Parsed float-style int: {result2}");

                // Parsing thousands separator
                int result3 = int.Parse(
                    numStr3,
                    NumberStyles.AllowThousands,
                    CultureInfo.InvariantCulture);

                Console.WriteLine($"Parsed thousands: {result3}");

                // Parsing thousands + decimal (still into int)
                int result4 = int.Parse(
                    numStr4,
                    NumberStyles.AllowThousands | NumberStyles.Float,
                    CultureInfo.InvariantCulture);

                Console.WriteLine($"Parsed thousands + decimal: {result4}");

                // Parsing boolean
                bool boolValue = bool.Parse("True");
                Console.WriteLine($"Parsed bool: {boolValue}");

                // Parsing floating point number
                float floatValue = float.Parse("1.235", CultureInfo.InvariantCulture);
                Console.WriteLine($"Parsed float: {floatValue:F2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow error: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("===== USING TRYParse (Preferred) =====");

            // TryParse does NOT throw exceptions
            // Returns true if conversion succeeded
            if (int.TryParse(numStr1, out int intResult))
            {
                Console.WriteLine($"TryParse int success: {intResult}");
            }

            // TryParse with NumberStyles and Culture
            if (int.TryParse(
                numStr3,
                NumberStyles.AllowThousands,
                CultureInfo.InvariantCulture,
                out int thousandsResult))
            {
                Console.WriteLine($"TryParse thousands success: {thousandsResult}");
            }

            // Parsing decimal safely
            if (decimal.TryParse(
                numStr4,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal decimalResult))
            {
                Console.WriteLine($"TryParse decimal success: {decimalResult:F2}");
            }

            // Safe boolean parsing
            if (bool.TryParse("true", out bool boolResult))
            {
                Console.WriteLine($"TryParse bool success: {boolResult}");
            }
        }
    }
}