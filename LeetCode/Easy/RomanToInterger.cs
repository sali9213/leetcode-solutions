using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class RomanToInterger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {

                if(i < s.Length - 1 && dic[s[i]] < dic[s[i+1]])
                {
                    result += dic[s[i + 1]] - dic[s[i]];
                    i++;
                } else
                {
                    result += dic[s[i]];
                }
            }

            return result;
        }
    }
}
