public class Solution {
    public int[] ProductExceptSelf(int[] nums)
        {
            int zero_count = 0, product = 1, single_zero_index = 0;
            int[] res = new int[nums.Length];
            
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    single_zero_index = i;
                    zero_count++;
                }
                else
                    product *= nums[i];
                if (zero_count >1)
                {
                    return res;
                }
            }

            if(zero_count == 1)
            {
                res[single_zero_index] = product;
                return res;
            }

            if(zero_count == 0)
            {
                for (int i=0; i<nums.Length;i++)
                {
                    res[i] = product / nums[i];
                }
            }
            return res; 
        }
}
