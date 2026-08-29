public class Solution {
    public bool IsValid(string s) 
{
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> kps = new Dictionary<char, char>();
            kps[')'] = '(';
            kps['}'] = '{';
            kps[']'] = '[';
            foreach (char c in s)
            {
                if (kps.ContainsKey(c))
                {
                    if (stack.Count > 0 && stack.Peek() == kps[c])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
}
