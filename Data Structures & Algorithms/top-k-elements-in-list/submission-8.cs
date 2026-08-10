public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
            // create frequency map using dictionary 
            Dictionary<int, int> freqmap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!freqmap.ContainsKey(num))
                {
                    freqmap[num] = 0;
                }
                freqmap[num]++;
            }

            // create frequency list of length k 
            List<int>[] freqList = new List<int>[nums.Length + 1];
            for (int i = 0; i < nums.Length + 1; i++)
            {
                freqList[i] = new List<int>();
            }

            // sort values into frequency lists  
            foreach (var entry in freqmap)
            {
                freqList[entry.Value].Add(entry.Key);
            }

            // return list of last k values from the bucketsort 
            int[] res = new int[k];
            int index = 0;
            for (int j = nums.Length; j > 0; j--)
            {
                foreach (var entry in freqList[j])
                {
                    res[index++] = entry;
                    if (index == k)
                    {
                        return res;
                    }
                }
            }
            return res;
        }
}
