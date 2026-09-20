public class Solution {
 public int Search(int[] nums, int target)
        {
            return BinarySearch1(0, nums.Length - 1, nums, target);
        }

        public int BinarySearch1 (int start, int end, int[] nums, int target)
        {
            if(start > end)
            {
                return -1;
            }

            int m = start + (end - start) / 2;

            if (nums[m] == target)
            {
                return m;
            }
            else if (nums[m] > target)
            {
                // target in first half 
                return BinarySearch1(start, m - 1, nums, target); 
            }
            else if (nums[m] < target)
            {
                // target in second half
                return BinarySearch1(m + 1, end, nums, target);
            }
            return -1;
        }

}
