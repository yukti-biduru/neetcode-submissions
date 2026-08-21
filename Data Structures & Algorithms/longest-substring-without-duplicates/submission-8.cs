public class Solution {
public int LengthOfLongestSubstring(string s)
        {
            int l = 0, max = 0;
            HashSet<char> chars = new HashSet<char>();

            for(int r=0; r<s.Length; r++)
            {
                while (chars.Contains(s[r]))
                {
                    chars.Remove(s[l]);
                    l++;
                }
                chars.Add(s[r]);
                max = Math.Max(max, r - l + 1);
            }
            return max;
        }
}
