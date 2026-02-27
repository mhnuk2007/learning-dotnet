using System;
using System.Text;
namespace FunctionCodeChallenge
{
    class Program
    {
        static void Main()
        {
            string[] teststrings =
            {
            "Hello World!",
            "Race car!",
            "Rotor",
            "More cowbell!",
            "Madam, I'm Adam."
        };

            int palcount = 0;

            foreach (string str in teststrings)
            {
                bool learnerResult = Answer.IsPalindrome(str);
                Console.WriteLine($"{str} → {learnerResult}");

                if (learnerResult)
                    palcount++;
            }

            Console.WriteLine($"\nTotal Palindromes: {palcount}");
        }
    }
}