public class Solution {
    public int EvalRPN(string[] tokens) 
    {
            Stack<int> stack = new Stack<int>();
            int x, y;
            foreach (string str in tokens)
            {
                if (str == "+")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(x + y);
                }
                else if (str == "-")
                {

                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(y - x);
                }
                else if (str == "*")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(x * y);
                }
                else if (str == "/")
                {
                    x = stack.Pop();
                    y = stack.Pop();
                    stack.Push(y / x);
                }
                else
                {
                    stack.Push(int.Parse(str));
                }
            }

            return stack.Pop();
        }
}
