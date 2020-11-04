using System;
namespace LeetCode.Medium
{
    public static class P50_MyPow
    {
        public static double MyPow(double x, int n)
        {
            if (x == 1) return x;
            else if (n == 0) return 1;
            else if (n == 1) return x;

            double add = 1;

            if (n == int.MinValue)
            {
                add = x;
                n += 1;
            }

            if (n < 0)
            {
                x = 1 / x;
                n *= -1;
            }

            bool isOdd = Math.Abs(n) % 2 == 1;

            return isOdd ? add * x * MyPow(x * x, (n - 1) / 2) : add * MyPow(x * x, n / 2);

        }
    }
}
