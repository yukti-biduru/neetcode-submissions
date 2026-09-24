public class Solution {
    public bool IsPalindrome(string s) {
        // use chars that are alphanumeric 
        // check from both sides  
        s = s.ToLower();
        int l=0, r=s.Length-1; 
        while (l<r)
        {
            while(l < s.Length-1 && !IsAlphaNumeric(s[l]))
            {
                Console.WriteLine("l"+l);
                l++;     
            }
            while(r > 0 && !IsAlphaNumeric(s[r]))
            {
                Console.WriteLine("r" + r);
                r--;     
            }
            Console.WriteLine(l);
            Console.WriteLine(r);
            if(l>r)
             return true;
            if(s[l] != s[r])
            {
                return false;
            }
            else 
            {
                l++;
                r--;
            }
        }
        return true;
    }

    public bool IsAlphaNumeric (char c)
    {
        if((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
        {
            return true;
        }
        return false;
    }
}
