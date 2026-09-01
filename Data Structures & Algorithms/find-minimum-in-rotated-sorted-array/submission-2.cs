public class Solution {
    public int FindMin(int[] nums) 
    {
            int l = 0, r = nums.Length - 1;
            int res = nums[0];
            while (l<=r)
            {
                if (nums[l]<= nums[r])
                {
                    res = Math.Min(res, nums[l]);
                    break;
                }

                int m = (l + r) / 2;
                res = Math.Min(res, nums[m]);
                if (nums[m] >= nums[l]) // left side is sorted, search in right side 
                {
                    l = m + 1;
                }
                else // right side is sorted, search in left side
                {
                    r = m - 1;
                }
            }
            return res;
        }

}
