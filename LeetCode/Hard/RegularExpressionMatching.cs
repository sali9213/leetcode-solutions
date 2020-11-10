using System;
namespace LeetCode.Hard
{
    public static class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0) return s.Length == 0;
            bool first_match = (!(s.Length == 0) && (p[0] == s[0] || p[0] == '.'));

            if(p.Length >= 2 && p[1] == '*')
            {
                return (IsMatch(s, p.Substring(2)) || (first_match && IsMatch(s.Substring(1), p)));
            } else
            {
                return first_match && IsMatch(s.Substring(1), p.Substring(1));
            }
        }

    }
}
