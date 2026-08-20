public class Solution {
    public int CharacterReplacement(string s, int k) 
  {
            HashSet<char> chars = new HashSet<char>(s);
            int max = 0; 
            foreach(char c in chars)
            {
                int l = 0, count = 0;
                for (int r=0; r<s.Length; r++)
                {
                    if (s[r] == c)
                    {
                        count++;
                    }

                    while((r-l+1)-count > k)
                    {
                        if (s[l] == c)
                            count--;
                        l++;
                    }
                    max = Math.Max(r-l+1, max);
                }
            }
            return max;
        }
}
