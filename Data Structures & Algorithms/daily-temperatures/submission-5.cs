public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
{
            int n = temperatures.Length;
            int[] res = new int[n];

            Stack<int> stack = new Stack<int>();

            for (int i=0; i<n; i++)
            {
                int curr_temp = temperatures[i];

                while(stack.Count > 0 && temperatures[stack.Peek()] < curr_temp)
                {
                    res[stack.Peek()] = i - stack.Peek();
                    stack.Pop();
                }
                stack.Push(i);
            }
            return res;
        }
}
