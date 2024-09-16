namespace Leetcode75;

public abstract partial class Questions
{
    public static int MaxProfit(int[] prices)
    {
        var left = 0;
        var right = 0;
        var maxProfit = 0;

        if(prices.Length <= 1) return 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                var profit = prices[right] - prices[left];
                maxProfit = Math.Max(profit, maxProfit);
            }
            else
            {
                left = right;
            }

            right++;
        }
        
        return maxProfit;
    }
}