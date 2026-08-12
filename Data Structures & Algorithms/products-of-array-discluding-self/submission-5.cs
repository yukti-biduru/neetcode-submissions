public class Solution {
    public int[] ProductExceptSelf(int[] nums)
       {
           int[] suffix = new int[nums.Length];
           int[] res = new int[nums.Length];

           int n = nums.Length;

           res[0] = 1;

           for (int i = 1; i < n; i++)
           {
               res[i] = nums[i - 1] * res[i - 1];
           }
            int postfix = 1;
           for (int j = n - 1; j >= 0; j--)
           {
                res[j] *= postfix;
                postfix *= nums[j];
           }
           return res;
       }
}
