using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            string num = n.ToString();
            bool isDone = false;
            bool isHappy = false;

            Dictionary<int, bool> tracker = new Dictionary<int, bool>();

            while (!isDone)
            {
                int currentSum = 0;

                foreach (char c in num)
                {
                    currentSum += (int)Math.Pow(int.Parse(c.ToString()), 2);
                }

                if (currentSum == 1)
                {
                    isDone = true;
                    isHappy = true;
                }
                else if (tracker.ContainsKey(currentSum) && tracker[currentSum])
                {
                    isDone = true;
                } else
                {
                    tracker[currentSum] = true;
                }

                num = currentSum.ToString();
            }

            return isHappy;

        }
    }
}
