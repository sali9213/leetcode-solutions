using System;
using System.Linq;

namespace LeetCode
{
    public class Plaindrome
    {
        public Plaindrome()
        {
        }

        public static string LongestPalindrome(string s)
        {
            if (s == "") return s;

            int str_end = s.Count() - 1;

            for (int i = str_end; i >= 1; i--)
            {
                int indx_start = 0;
                int indx_end = i;
                //difference between the end of the index and the size of the string to determine how much the sliding window needs to be moved
                int diff = str_end - i;

                for (int j = 0; j <= diff; j++)
                {
                    if (j != 0)
                    {
                        indx_start += 1;
                        indx_end += 1;
                    }
                    Console.WriteLine($"index end = {indx_end}, index start = {indx_start}, diff = {diff}");
                    if (IsPalindrome(s.Substring(indx_start, indx_end - indx_start + 1)))
                    {
                        return s.Substring(indx_start, indx_end - indx_start + 1);
                    }
                }
            }

            return s[0].ToString();

        }

        public static bool IsPalindrome(string s)
        {
            // Check if string is a palindrome and return true if it is.
            if (s.Equals(ReverseString(s)))
            {
                return true;
            }

            return false;
        }

        public static string ReverseString(string s)
        {
            // Revers the string for palindrome check
            char[] arr = s.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
