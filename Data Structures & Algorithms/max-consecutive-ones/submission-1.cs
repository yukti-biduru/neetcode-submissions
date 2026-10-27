public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, count = 0;
        for(int i=0; i<nums.Length; i++)
        {
            count = nums[i] == 0? 0: count+1;
            max = Math.Max(max, count);
        }
        return max;    
    }
}