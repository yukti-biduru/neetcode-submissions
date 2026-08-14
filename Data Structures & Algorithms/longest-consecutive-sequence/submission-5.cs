public class Solution {
    public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            nums = nums.Distinct().ToArray();
            Array.Sort(nums);

            int res = 0, streak = 0, curr = 0, i = 0;
            while (i < nums.Length)
            {
                if (curr != nums[i])
                {
                    curr = nums[i];
                    streak = 0;
                }
                while (i < nums.Length && curr == nums[i])
                {
                    streak++;
                    curr++;
                    i++;
                }
                res = Math.Max(res, streak);
            }
            return res;
        }

}