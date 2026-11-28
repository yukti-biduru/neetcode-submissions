public class Solution {
    public int[] SortArray(int[] nums) {
        // selection sort
        int index = 0, min = 0, n=nums.Length;
        for (int i=0; i<n; i++)
        {
            min = i;
            for (int j=i+1; j<n; j++)
            {
                if(nums[min]>nums[j])
                {
                    min = j;
                }
            }
            
                int temp = nums[i];
                nums[i] = nums[min];
                nums[min] = temp;
            
        }
        return nums;
    }
}