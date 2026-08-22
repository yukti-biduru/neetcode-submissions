public class Solution {
    public string MinWindow(string s, string t) 
    {
            // Sliding window is the best approach 
            // Load the string t to dictionary
            // move right side of window until all chars of t are covered  
            // move left side of window until the start of first t char 

            Dictionary<char, int> tCount = new Dictionary<char, int>();
            Dictionary<char, int> sCount = new Dictionary<char, int>();

            foreach (char c in t)
            {
                if (tCount.ContainsKey(c))
                {
                    tCount[c]++;
                }
                else
                {
                    tCount[c] = 1;
                }
            }
            int l = 0;
            int have = 0, need = tCount.Count;
            int resLen = int.MaxValue;
            int[] res = { -1, -1 };

            for (int r = 0; r < s.Length; r++)
            {
                char c = s[r];
                if (sCount.ContainsKey(c))
                {
                    sCount[c]++;
                }
                else
                {
                    sCount[c] = 1;
                }
                // move r until we cover all t characters
                if (tCount.ContainsKey(c) && tCount[c] == sCount[c])
                {
                    have++;
                }

                // after the have == need move l
                while (have == need)
                {
                    if ((r - l + 1) < resLen)
                    {
                        res[0] = l;
                        res[1] = r;
                        resLen = r - l + 1;

                    }
                    sCount[s[l]]--;
                    if (tCount.ContainsKey(s[l]) && tCount[s[l]] == sCount[s[l]] + 1)
                    {
                        have--;
                    }
                    l++;
                }

            }
            return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
        }
}
