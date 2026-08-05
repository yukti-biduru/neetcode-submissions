public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] keyArr = new char[26];
                foreach (char c in str)
                {
                    keyArr[c - 'a']++;
                }
                string key = new string(keyArr);
                if (!result.ContainsKey(key))
                {
                    result[key] = new List<string>();
                }
                result[key].Add(str);
            }
            return result.Values.ToList();
    }
}
