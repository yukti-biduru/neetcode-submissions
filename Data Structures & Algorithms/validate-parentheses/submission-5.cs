public class Solution {
    public bool IsValid(string s) 
{
            Stack<char> chars = new Stack<char>();
            Dictionary<char, char> kps = new Dictionary<char, char>();
            kps[')'] = '(';
            kps['}'] = '{';
            kps[']'] = '[';

            foreach(char c in s)
            {
                if(kps.ContainsKey(c))
                {
                    if(chars.Count > 0 && chars.Peek() == kps[c])
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    chars.Push(c);
                }
            }
            return chars.Count == 0;
        }
}
