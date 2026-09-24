public class Solution {
    public int CharacterReplacement(string s, int k) {
        // find longest val for each char in the string
        // add length starting from the first index of the char
        // keep adding until k excess is reached
        // check max value
        int max = 0;
        HashSet<int> chars  = new HashSet<int>(); 
        foreach(char c in s)
        {
            chars.Add(c);
        }

        foreach(char c in chars)
        {
            int length = 0, l=0; 
            for (int r = 0; r<s.Length; r++)
            {
                if (s[r]==c)
                {
                    length++;
                }

                while ((r-l+1 -length > k))
                { 
                    if(s[l]==c)
                    {
                        length--; 
                    }
                    l++;
                }
                max = Math.Max(max, r-l+1);
            }
        }
        return max;
    }
}
