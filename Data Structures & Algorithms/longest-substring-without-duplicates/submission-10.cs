public class Solution {
public int LengthOfLongestSubstring(string s)
     {
                        int l = 0, max = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int r=0; r<s.Length; r++)
            {
                if (map.ContainsKey(s[r]))
                {
                    l = Math.Max(map[s[r]] + 1, l);
                }
                map[s[r]] = r;
                max = Math.Max(max, r - l + 1);
            }
            return max; 
     }
}
