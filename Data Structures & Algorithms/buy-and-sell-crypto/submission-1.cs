public class Solution {
    public int MaxProfit(int[] prices) 
    {
        // calculate running min 
        // calculate running max 
        // calculate difference
        // save max and return value 

        int min = int.MaxValue, diff, res=0;
        int n = prices.Length;
        for(int i=0; i<n; i++)
        {
            min = Math.Min(min, prices[i]);
            res = Math.Max(res,prices[i] - min);
        }
        return res;
    }
}
