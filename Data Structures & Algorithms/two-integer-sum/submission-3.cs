public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int[]> A = new List<int[]>(); 
        // create List of integer array {nums[i], i}
        for(int id=0; id < nums.Length; id++)
        {
            A.Add(new int[]{nums[id], id});
        }
        A.Sort((a,b)=> a[0].CompareTo(b[0]));

        int i=0, j= nums.Length - 1; 
        while(i<j)
        {
            int cur = A[i][0] + A[j][0];
            if (cur == target){
                return new int[] {
                    Math.Min(A[i][1], A[j][1]), 
                    Math.Max(A[i][1], A[j][1])
                };
            }
            else if (cur < target){
                i++;
            }
            else 
            {
                j--;
            }
        }
        return new int[0];
    }
}
