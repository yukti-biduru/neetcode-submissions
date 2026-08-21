public class Solution {
        public int CharacterReplacement(string s, int k)
        {
            // longest substring - two pointer, sliding window  
            // k most replacements  

            // we need to find the most recurring char, but doesnt mean that will be the char that is required. 
            // so instead, we check for every char since it will be at most 26 loops 

            HashSet<char> chars = new HashSet<char>(s);
            int max = 0; 

            foreach(char c in chars)
            {
                int count = 0, l = 0;
                for (int r=0;  r < s.Length; r++)
                {
                    if (s[r] == c)
                    {
                        count++;
                    }
                    // move left pointer
                    while((r-l+1) - count > k)
                    {
                        //if c is being skipped decrease count  
                        if (s[l] == c)
                        {
                            count--;
                        }
                        l++;
                    }
                    max = Math.Max(max, r - l + 1);
                }
            }
            return max;
        }

}
