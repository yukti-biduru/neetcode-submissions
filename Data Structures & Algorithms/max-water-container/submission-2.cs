public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length-1; 
        int max = 0, area;
        while (l<r)
        {
            area = Math.Min (heights[l], heights[r])*(r-l);
            max = Math.Max(max, area); 
            if(heights[l]>heights[r])
            {
                r--;
            }
            else if (heights[l]<heights[r])
            {
                l++;
            }
            else 
            {
                l++; 
                r--; 
            }
        }
        return max;
    }
}
