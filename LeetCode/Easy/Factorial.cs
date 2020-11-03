using System;
namespace LeetCode.Easy
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            if (n == 1) return n;
            return n * GetFactorial(n - 1);
        }

    }
}
