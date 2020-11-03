using System;
namespace LeetCode.Medium
{
    public static class Prob1_ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int max = 0;
            int i = 0;
            int j = height.Length - 1;

            while(j > i)
            {
                int area = (j - i) * (height[i] < height[j] ? height[i++] : height[j--]);
                if (area > max) max = area;
            }

            return max;
        }
    }
}
