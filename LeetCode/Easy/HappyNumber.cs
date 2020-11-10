using System;
namespace LeetCode.Easy
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            string num = n.ToString();
            bool isDone = false;
            bool isHappy = false;

            while (!isDone)
            {
                int previousSum = int.MaxValue;
                int currentSum = 0;

                foreach (char c in num)
                {
                    currentSum += (int)Math.Pow((int)c, 2);
                    if(currentSum > previousSum)
                    {
                        isDone = true;
                    } else
                    {

                    }
                }
            }

        }
    }
}
