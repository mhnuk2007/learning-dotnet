using System;
using System.Text;

namespace FunctionCodeChallenge
{
    public class Answer
    {
        public static bool IsPalindrome(string thestr)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in thestr)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(char.ToLower(c));
            }

            string teststr = sb.ToString();

            int left = 0;
            int right = teststr.Length - 1;

            while (left < right)
            {
                if (teststr[left] != teststr[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}