﻿using System;
namespace LeetCode.Easy
{
    public static class PlaindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 10 && x > -1) return true;
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int revertedNumber = 0;
            while(x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        
        }
    }
}
