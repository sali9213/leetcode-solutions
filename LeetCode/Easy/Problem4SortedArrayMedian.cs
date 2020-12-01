using System;
namespace LeetCode
{
    public static class SortedArrayMedian
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            double result = 0;

            // Concatenate the two arrays
            int[] nums = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(nums, 0);
            nums2.CopyTo(nums, nums1.Length);

            Array.Sort(nums);

            if(nums.Length % 2 == 0)
            {
                result = (nums[(nums.Length / 2) - 1] + nums[(nums.Length / 2)]);
                result = result / 2;

            } else
            {
                result = nums[((nums.Length + 1) / 2) - 1];
            }

            return result;

        }
    }
}
