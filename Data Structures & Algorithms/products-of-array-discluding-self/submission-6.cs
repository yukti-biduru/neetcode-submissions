public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        // product of array except self  
        int n = nums.Length, mul=1;
        int[] res = new int[n];
        
        // product until before the number from start
        res[0] = 1;
        for(int i=1; i<n; i++)
        {
            res[i] = res[i-1]*nums[i-1];
        } 
        
        // product until after the number from end 
        for(int i=n-2; i>=0; i--)
        {
            mul *= nums[i+1];
            res[i] *= mul;
        }
        return res;
    }
}
