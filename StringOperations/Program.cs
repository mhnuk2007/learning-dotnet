using System;
using System.Text;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string str4 = "   padded text   ";
            string[] strs = { "one", "two", "three", "four" };

            Console.WriteLine("===== LENGTH =====");
            Console.WriteLine(str1.Length);
            Console.WriteLine(strs.Length);
            Console.WriteLine();

            Console.WriteLine("===== CHARACTER ACCESS =====");
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[^1]); // last character (C# index from end)
            Console.WriteLine();

            Console.WriteLine("===== ITERATION =====");
            foreach (char c in str1)
                Console.Write($"{c} ");
            Console.WriteLine("\n");

            Console.WriteLine("===== CONCATENATION =====");
            Console.WriteLine(str1 + " " + str2);
            Console.WriteLine($"{str1} {str2}");
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine(string.Join(",", strs));
            Console.WriteLine();

            Console.WriteLine("===== STRINGBUILDER =====");
            var sb = new StringBuilder();
            sb.Append(str1);
            sb.Append(" ");
            sb.Append(str2);
            outstr = sb.ToString();
            Console.WriteLine(outstr);
            Console.WriteLine();

            Console.WriteLine("===== COMPARISON =====");
            Console.WriteLine(str2 == str3);
            Console.WriteLine(str2.Equals(str3));
            Console.WriteLine(str2.Equals(str3, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Compare(str2, str3, true)); // ignore case
            Console.WriteLine();

            Console.WriteLine("===== SEARCHING =====");
            Console.WriteLine(str1.Contains("fox"));
            Console.WriteLine(str1.Contains("FOX", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(str1.StartsWith("The"));
            Console.WriteLine(str1.EndsWith("dog."));
            Console.WriteLine(str1.IndexOf("fox"));
            Console.WriteLine(str1.LastIndexOf("o"));
            Console.WriteLine();

            Console.WriteLine("===== SUBSTRING =====");
            Console.WriteLine(str1.Substring(4, 5)); // quick
            Console.WriteLine();

            Console.WriteLine("===== REPLACE =====");
            Console.WriteLine(str1.Replace("fox", "cat"));
            Console.WriteLine();

            Console.WriteLine("===== SPLIT =====");
            string[] words = str1.Split(' ');
            foreach (var w in words)
                Console.WriteLine(w);
            Console.WriteLine();

            Console.WriteLine("===== TRIM =====");
            Console.WriteLine(str4.Trim());
            Console.WriteLine(str4.TrimStart());
            Console.WriteLine(str4.TrimEnd());
            Console.WriteLine();

            Console.WriteLine("===== CASE CONVERSION =====");
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str3.ToLower());
            Console.WriteLine();

            Console.WriteLine("===== INSERT & REMOVE =====");
            Console.WriteLine(str2.Insert(4, " definitely"));
            Console.WriteLine(str2.Remove(4, 3));
            Console.WriteLine();

            Console.WriteLine("===== STRING FORMAT =====");
            string name = "Honey";
            int age = 20;
            Console.WriteLine(string.Format("{0} is {1} years old.", name, age));
            Console.WriteLine($"{name} is {age} years old.");
            Console.WriteLine();

            Console.WriteLine("===== NULL OR EMPTY CHECKS =====");
            string empty = "";
            string? nullStr = null;

            Console.WriteLine(string.IsNullOrEmpty(empty));
            Console.WriteLine(string.IsNullOrWhiteSpace("   "));
            Console.WriteLine(string.IsNullOrEmpty(nullStr));
            Console.WriteLine();

            Console.WriteLine("===== STRING INTERPOLATION FORMATTING =====");
            double price = 1234.5678;
            Console.WriteLine($"{price:F2}");     // 2 decimal places
            Console.WriteLine($"{price:C}");      // currency
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd}");
            Console.WriteLine();

            Console.WriteLine("===== STRING TO CHAR ARRAY =====");
            char[] chars = str1.ToCharArray();
            Console.WriteLine(chars[0]);
        }
    }
}