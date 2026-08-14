public class Solution {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (!IsAlphaNum(s[i]))
                {
                    i++;
                }
                else if (!IsAlphaNum(s[j]))
                {
                    j--;
                }
                else if (s[i] != s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }

        
        public bool IsAlphaNum(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            else if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }

        }


}
