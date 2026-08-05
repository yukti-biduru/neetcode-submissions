public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                var sortedArr = str.ToCharArray();
                Array.Sort(sortedArr);
                var sortedStr = new string(sortedArr);
                if(!result.ContainsKey(sortedStr))
                {
                    result[sortedStr] = new List<string>();
                }
                    result[sortedStr].Add(str);
            }
            return result.Values.ToList();

    }
}
