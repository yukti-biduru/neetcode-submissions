public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    { 
            Dictionary<int,int> val_freq = new Dictionary<int,int>();
            foreach (int num in nums)
            {
                if (!val_freq.ContainsKey(num))
                {
                    val_freq[num] = 0;
                }
                val_freq[num]++;
            }

            List<int>[] freq = new List<int>[nums.Length + 1]; 
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = new List<int>();
            }

            foreach(var entry in val_freq)
            {
                freq[entry.Value].Add(entry.Key);
            }

            int[] res = new int[k];
            int index = 0;
            for(int j = freq.Length - 1; j > 0 && index < k; j--)
            {
                foreach(int n in freq[j])
                {
                    res[index] = n;
                    index++; 
                    if(index == k)
                    {
                        return res; 
                    }
                }
            }
            return res; 
        }
}
