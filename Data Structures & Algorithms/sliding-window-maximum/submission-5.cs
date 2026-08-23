public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) 
        {
            List<int> res = new List<int>();
            PriorityQueue<(int val, int ind), int> pq = new PriorityQueue<(int val, int ind), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int r = 0; r < nums.Length; r++)
            {
                pq.Enqueue((nums[r], r), nums[r]);

                if (r >= k - 1)
                {
                    while (pq.Peek().ind <= r - k)
                    {
                        pq.Dequeue();
                    }
                    res.Add(pq.Peek().val);
                }
            }
            return res.ToArray();
        }
    
}
