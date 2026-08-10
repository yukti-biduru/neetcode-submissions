public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
            // create frequency map using dictionary 
            Dictionary<int,int> val_freq = new Dictionary<int, int> ();
            foreach(int num in nums)
            {
                if(!val_freq.ContainsKey(num))
                {
                    val_freq[num] = 0;
                }
                val_freq[num]++;
            }

            // load it into an 2D array 
            List<int[]> arr = val_freq.Select(entry => new int[] { entry.Value, entry.Key }).ToList();

            // Sort by frequency in descending order 
            arr.Sort((a, b) => b[0].CompareTo(a[0]));

            int[] res = new int[k];
            // extract k most frequent values  
            int index = 0; 
            foreach (var val in arr)
            {
                res[index++] = val[1];
                if (index == k)
                    return res;
            }
            return res;

        }
}
