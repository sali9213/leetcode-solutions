using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public static class ZigZagConversion
    {

        public static string Convert(string s, int numRows)
        {
            string[] rows = new string[numRows];
            bool increasing = true;
            int currRow = 0;

            for(int i = 0; i < s.Length; i++)
            {
                //if (rows[currRow] == null)
                //    rows[currRow] = new List<char>();

                rows[currRow] += s[i];

                if (numRows > 1)
                {
                    if (currRow == 0) increasing = true;
                    else if (currRow == numRows - 1) increasing = false;

                    if (increasing) currRow++;
                    else currRow--;
                }
            }

            string result = "";

            foreach(var row in rows)
            {
                result += row;
            }

            return result;
        }
    }
}
