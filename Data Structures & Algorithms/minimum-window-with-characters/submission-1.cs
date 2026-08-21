public class Solution {
    public string MinWindow(string s, string t) 
    { 
            Dictionary<char, int> countT = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            for (int i=0; i < t.Length; i++)
            {
                char c = t[i]; 
                if(countT.ContainsKey(c))
                {
                    countT[c]++;
                }
                else
                {
                    countT[c] = 1;
                }
            }

            int have = 0, need = countT.Count;
            int resLen = int.MaxValue;
            int[] res = { -1, -1 };
            int l = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (window.ContainsKey(c))
                {
                    window[c]++; 
                }
                else
                {
                    window[c] = 1;
                }

                if (countT.ContainsKey(c) && window[c] == countT[c])
                {
                    have++;
                }

                while(have == need)
                {
                    if((i-l+1)<resLen)
                    {
                        resLen = i - l + 1;
                        res[0] = l;
                        res[1] = i;
                    }

                    char leftchar = s[l];
                    window[leftchar]--;

                    if(countT.ContainsKey(leftchar) && window[leftchar] < countT[leftchar])
                    {
                        have--;
                    }
                    l++;
                }
            }
            return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
        }
}
