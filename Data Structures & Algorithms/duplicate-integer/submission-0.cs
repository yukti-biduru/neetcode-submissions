public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary <int,int> ind = new Dictionary <int,int>(); 
        for (int i = 0; i < nums.Length; i++)
        {
            if(ind.ContainsKey(nums[i]))
            {
                return true; 
            }
            ind[nums[i]] = i;
        }
        return false; 
    }
}