public class Solution {
    public int MaxArea(int[] heights)
        {
            int res = 0, area, n = heights.Length, l = 0, r = n - 1;

            while (l < r)
            {
                area = Math.Min(heights[l], heights[r]) * (r - l);
                if (heights[l] > heights[r])
                {
                    r--;
                }
                else if (heights[l] < heights[r])
                {
                    l++;
                }
                else
                {
                    r--;
                    l++;
                }
                res = Math.Max(res, area);
            }
            return res;
        }
}
