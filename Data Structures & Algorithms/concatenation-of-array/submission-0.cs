public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] nums2 = new int[nums.Length*2]; 
        int j=0;
        for(int i=0; i<nums2.Length; i++)
        {
            if(i == nums.Length)
            {
                j=0;
            }
            nums2[i] = nums[j]; 
            j++;
        }
        return nums2;
    }
}