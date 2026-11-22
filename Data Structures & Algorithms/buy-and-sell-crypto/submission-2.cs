public class Solution {
    public int MaxProfit(int[] prices)
        {
            int n = prices.Length, min=int.MaxValue, profit = 0;

            for (int i=0; i<n; i++)
            {
                min = Math.Min(min, prices[i]);
                profit = Math.Max (profit, prices[i] - min);
            }
            return profit;

        }
}
