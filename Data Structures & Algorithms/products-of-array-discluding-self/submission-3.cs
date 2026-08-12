public class Solution {
    public int[] ProductExceptSelf(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];
            int[] res = new int[nums.Length];

            int n = nums.Length;

            prefix[0] = 1;
            suffix[n - 1] = 1;
            for(int i=1; i<n; i++)
            {
                prefix[i] = nums[i - 1] * prefix[i - 1];
            }

            for(int j=n-2; j>=0; j--)
            {
                suffix[j] = nums[j + 1] * suffix[j + 1];
            }

            for (int i=0; i<n; i++)
            {
                res[i] = prefix[i] * suffix[i];
            }
            return res;

        }
}
