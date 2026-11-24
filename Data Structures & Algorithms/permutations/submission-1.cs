public class Solution {
        public List<List<int>> Permute(int[] nums)
    {
        var result = new List<List<int>>();
        var visited = new bool[nums.Length];
        helper(nums, result, visited, new List<int>());
        return result;
    }

    private void helper(int[] nums, List<List<int>> result, bool[] visited, List<int> current)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!visited[i])
            {
                current.Add(nums[i]);
                visited[i] = true;
                helper(nums, result, visited, current);
                visited[i] = false;
                current.Remove(nums[i]);
            }
        }
    }

}
