public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length; 
        int[] nums2 = new int[2*n]; 
        for(int i=0; i<n;i++)
        {
            nums2[i] = nums2[i+n] = nums[i];
        }
        return nums2;
    }
}