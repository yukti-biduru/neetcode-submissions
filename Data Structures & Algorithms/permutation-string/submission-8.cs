public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
            // we need to find the permutation of s1 in s2 
            // we use sliding window 
            // finding a substring and sorting is the first approach but that will take more computational power
            // so what we can do is, we keep track of the frequency of letters, add/subtract as we slide the window
            // when a match of freqency is reached, we return true else we return false  

                        if (s1.Length > s2.Length)
                return false;

            // frequency of s1
            int[] s1Arr = new int[26];
            int[] window = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                s1Arr[s1[i] - 'a']++;
                window[s2[i] - 'a']++;
            }
            int match = 0;
            for (int i = 0; i < 26; i++)
            {
                if (window[i] == s1Arr[i])
                {
                    match++;
                }
            }

            int l = 0;
            for (int r = s1.Length; r < s2.Length; r++)
            {
                if (match == 26)
                {
                    return true;
                }

                window[s2[r] - 'a']++;
                if (s1Arr[s2[r] - 'a'] == window[s2[r] - 'a'])
                {
                    match++;
                }
                else if(s1Arr[s2[r] - 'a'] + 1 == window[s2[r] - 'a']) // only remove match if value differs due to the current increment
                {
                    match--;
                }
                window[s2[l] - 'a']--;
                if (s1Arr[s2[l] - 'a'] == window[s2[l] - 'a'])
                {
                    match++;
                }
                else if(s1Arr[s2[l] - 'a'] - 1 == window[s2[l] - 'a']) // only remove match if value differs due to the current decrement
                {
                    match--;
                }   
                l++;
            }
            return match == 26;

        }
}
