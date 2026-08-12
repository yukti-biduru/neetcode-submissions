public class Solution {
    public int[] ProductExceptSelf(int[] nums)
       {
           int[] suffix = new int[nums.Length];
           int[] res = new int[nums.Length];

           int n = nums.Length;

           res[0] = 1;
           suffix[n - 1] = 1;
           for (int i = 1; i < n; i++)
           {
               res[i] = nums[i - 1] * res[i - 1];
           }

           for (int j = n - 2; j >= 0; j--)
           {
               suffix[j] = nums[j + 1] * suffix[j + 1];
               res[j] *= suffix[j];
           }
           return res;
       }
}
