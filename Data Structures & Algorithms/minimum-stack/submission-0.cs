public class MinStack {
private Stack<int> stack;
        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            int val, min = int.MaxValue;
            Stack<int> temp = new Stack<int>();
            while (stack.Count > 0)
            {
                val = stack.Pop();
                min = Math.Min(min, val);
                temp.Push(val);
            }

            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }
            return min;
        }
}
