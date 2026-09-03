public class Solution {
    public int Search(int[] nums, int target) 
    {
            int l = 0, r = nums.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;

                if (nums[m] == target)
                {
                    return m;
                }
                // left side is sorted nums[l] < nums[m]
                if (nums[m] >= nums[l])
                {
                    // if target is outside of the range
                    if (target < nums[l] || target > nums[m])
                    {
                        // target is in the right half
                        l = m + 1;
                    }
                    else
                    {
                        // target is in the left half 
                        r = m - 1;
                    }
                }
                // right side is sorted nums[m] < nums[r]
                else
                {
                    // if target is outside of the range
                    if (target < nums[m] || target > nums[r])
                    {
                        // target is in the left half 
                        r = m - 1;
                    }
                    else
                    {
                        // target is in the right half 
                        l = m + 1;
                    }
                }
            }
            return -1;
        }
}