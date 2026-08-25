public class Solution {
    public bool IsValid(string s) 
{
            Dictionary<char, char> map = new Dictionary<char, char>();
            map[')'] = '(';
            map['}'] = '{';
            map[']'] = '[';

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    if (stack.Count > 0 && stack.Peek() == map[c])
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
