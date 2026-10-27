public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, count = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                max = Math.Max(max, count);
                count = 0;
            }
            else 
            {
                count++;
            }
        }
        max = Math.Max(max, count);
        return max;    
    }
}