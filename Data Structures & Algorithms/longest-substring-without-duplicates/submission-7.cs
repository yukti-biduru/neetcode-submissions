public class Solution {
public int LengthOfLongestSubstring(string s)
        {
            /// instrad of looping through and remving chars for creating new substrings  
            /// we can save the index of the characters and then move to the next index to create the substring 

            Dictionary<char, int> map = new Dictionary<char, int>();

            int l = 0, max = 0;

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
