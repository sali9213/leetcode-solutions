using System;
namespace LeetCode.Easy
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            bool negative = false;

            if (x < Int32.MinValue + 1)
                return 0;

            if (x < 0)
            {
                x = -x;
                negative = true;
            }

            char[] num = x.ToString().ToCharArray();
            Array.Reverse(num);
            string reversedNum = new string(num);
            long res = long.Parse(reversedNum);
            if (negative)
                res = -res;
            if (res > Int32.MaxValue || res < Int32.MinValue) res = 0;
            return (int)res;
        }
    }
}
