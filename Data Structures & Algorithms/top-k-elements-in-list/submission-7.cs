public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
            // create frequency map using dictionary
            Dictionary<int, int> val_freq = new Dictionary<int, int>(); 
            foreach(int num in nums)
            {
                if(!val_freq.ContainsKey(num))
                {
                    val_freq[num] = 0; 
                }
                val_freq[num]++; 
            }

            // add to priority queue where value is the value and freq is the priority, remove lower priority if heap more than k 
            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
            int ind = 0;
            foreach(var entry in val_freq)
            {
                heap.Enqueue(entry.Key, entry.Value);
                if(heap.Count > k)
                {
                    heap.Dequeue();
                }
            }
            // move heap to result to return 
            int[] res = new int[k]; 
            for (int i = 0; i < k; i++)
            {
                res[i] = heap.Dequeue();
            }
            return res;
        }
}
