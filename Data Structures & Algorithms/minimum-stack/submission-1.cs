public class MinStack {
        private Stack<int> stack;
        private Stack<int> minstack;

        public MinStack()
        { 
            stack = new Stack<int>();
            minstack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);            
            minstack.Push(Math.Min(val, minstack.Count == 0 ? val : minstack.Peek()));

        }

        public void Pop()
        {
            stack.Pop();
            minstack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minstack.Peek();
        }
}
