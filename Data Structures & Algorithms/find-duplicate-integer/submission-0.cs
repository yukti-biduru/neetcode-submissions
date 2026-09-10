public class Solution {
    public int FindDuplicate(int[] nums) 
    {
            HashSet<int> ints = new HashSet<int>();

            foreach(int num in nums)
            {
                if (ints.Contains(num))
                    return num;
                else 
                    ints.Add(num);
            }
            return -1;
        }
}
