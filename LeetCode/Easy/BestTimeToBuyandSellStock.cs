using System;
namespace LeetCode.Easy
{
    public static class BestTimeToBuyandSellStock
    {
        public static int MaxProfit(int[] prices)
        { 
            int maxProfit = 0;
            int minBuyPrice = int.MaxValue;

            foreach(int price in prices)
            {
                if (price < minBuyPrice)
                {
                    minBuyPrice = price;
                }
                else if (price - minBuyPrice > maxProfit)
                {
                    maxProfit = price - minBuyPrice;
                }
            }

            return maxProfit;
        }

    }
}
