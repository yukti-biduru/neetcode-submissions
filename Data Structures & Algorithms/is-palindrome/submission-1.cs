public class Solution {
    public bool IsPalindrome(string s) 
    {
            int i = 0;
            List<char> str = new List<char>();
            if (s.Length == 0)
            {
                return true;
            }
            while (i < s.Length)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    str.Add(s[i]);
                }
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    str.Add(s[i]);
                }
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    str.Add(Convert.ToChar(Convert.ToInt32(s[i]) + 32));
                }
                i++;
            }
            string val1 = new string(str.ToArray());
            str.Reverse();
            string val2 = new string(str.ToArray());
            return val1 == val2;
        }
}
