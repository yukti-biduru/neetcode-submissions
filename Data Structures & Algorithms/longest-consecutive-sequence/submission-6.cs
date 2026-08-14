public class Solution {
    public int LongestConsecutive(int[] nums)
    {
            HashSet<int> store = new HashSet<int>(nums);

            int i = 0, length = 0, res = 0, curr;
            while (i < nums.Length)
            {
                if (!store.Contains(nums[i] - 1))
                {
                    curr = nums[i];
                    length = 0;
                    while (store.Contains(curr))
                    {
                        length++;
                        curr++;
                    }
                }
                res = Math.Max(res, length);
                i++;
            }
            return res;
        }

}