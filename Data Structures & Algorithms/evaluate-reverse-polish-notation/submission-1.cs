public class Solution {
    public int EvalRPN(string[] tokens) 
    {
            Stack<int> stack = new Stack<int>();

            foreach (string t in tokens)
            {
                int val = 0;
                int x, y;
                if (t == "+")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(x + y);
                }
                else if (t == "-")
                {

                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(y - x);
                }
                else if (t == "*")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(x * y);
                }
                else if (t == "/")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(y / x);
                }
                else
                {
                    stack.Push(int.Parse(t));
                }
            }
            return stack.Pop();
        }
}
