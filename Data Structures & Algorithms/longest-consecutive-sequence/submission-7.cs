public class Solution {
    public int LongestConsecutive(int[] nums) {
        // length of the longest consecutive sequence 
        // find seq for each val by adding to hashmap? 
        // if a smalled number does not exist only then it starts the seq  

        HashSet<int> vals = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!vals.Contains(num))
            {
                vals.Add(num);
            }
        }
        // O(n)
        int max = 0;
        int length = 0;
        foreach(int num in nums)
        {
            length = 0;
            if(!vals.Contains(num-1))
            {
                // num is the start value
                var val = num;
                while (vals.Contains(val))
                {
                    length++;
                    val++;
                }
                max = Math.Max(max, length);
            }
        }
        return max;

    }
}
