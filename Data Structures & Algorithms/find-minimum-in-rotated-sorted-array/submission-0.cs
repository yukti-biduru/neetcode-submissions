public class Solution {
    public int FindMin(int[] nums) 
    {
            int prev = nums[0];
            for (int i=1; i<nums.Length; i++)
            {
                if (prev > nums[i])
                {
                    return nums[i];
                }
            }
            return prev;
        }
}
