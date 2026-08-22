public class Solution {
    public string MinWindow(string s, string t) 
            {
            // Sliding window  

            Dictionary<char, int> tCount = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            // load t in dictionary 
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

            // move r until all chars of t are covered
            int have = 0, need = tCount.Count;
            int l = 0;
            int resLen = int.MaxValue;
            int[] res = { -1, -1 };

            for (int r = 0; r < s.Length; r++)
            {
                char c = s[r];
                if (window.ContainsKey(c))
                {
                    window[c]++;
                }
                else
                {
                    window[c] = 1;
                }

                if (tCount.ContainsKey(c) && tCount[c] == window[c])
                {
                    have++;
                }

                // move l until t chars are there in the substring
                while (have == need)
                {
                    // keep moving r and l and evaluating the values to find the min substring
                    if ((r - l + 1) < resLen)
                    {
                        resLen = r - l + 1;
                        res[0] = l;
                        res[1] = r;
                    }
                    window[s[l]]--;
                    if (tCount.ContainsKey(s[l]) && tCount[s[l]] == window[s[l]] + 1)
                    {
                        have--;
                    }
                    l++;
                }
            }
            return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
        }

}
