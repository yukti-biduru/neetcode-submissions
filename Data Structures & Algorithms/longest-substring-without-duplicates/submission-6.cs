public class Solution {
    public int LengthOfLongestSubstring(string s)
        {
            /// String s, length of the longest substring without duplicate chars 
            /// To check duplicates we need a hashset to extract contains in O(1)
            /// and to see all substrings we are using two pointer - start and end of the substring  
            /// 

            HashSet<char> chars = new HashSet<char>();

            // start is fixed, we will start from the 0th index and shift right pointer first
            int l = 0, max = 0;

            for (int r = 0; r < s.Length; r++)
            {
                // move l until the repeating s[r] is reached
                while (chars.Contains(s[r]))
                {
                    chars.Remove(s[l]);
                    l++;
                }

                // add the next letter to be considered in the substring
                chars.Add(s[r]);

                // evaluate the substring 
                max = Math.Max(max, r - l + 1);
            }

            return max;
        } 
}
