using System;
namespace LeetCode.Medium
{
    public static class MyPow
    {
        public static double Pow(double x, int n)
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

            return isOdd ? add * x * Pow(x * x, (n - 1) / 2) : add * Pow(x * x, n / 2);

        }
    }
}
