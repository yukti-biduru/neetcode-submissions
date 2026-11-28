public class Solution {
    public int[] SortArray(int[] nums) {
        // insertion sort
        int key, index, n= nums.Length;
        for (int i=1; i<n; i++)
        {
            key=nums[i];
            index = i-1;
            while(index >= 0 && key < nums[index])
            {
                nums[index+1] = nums[index];
                index--;
            }
            nums[index+1] = key;
        }
        return nums;
    }
}