public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
            // loop through the temperatures 
            // push values until you find a temp greater 

            Stack<int[]> stack = new Stack<int[]>();
            int[] res = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                int t = temperatures[i];
                while (stack.Count > 0 && t > stack.Peek()[0])
                {
                    int[] pair = stack.Pop();
                    res[pair[1]] = i - pair[1];
                }
                stack.Push(new int[] { t, i });
            }
            return res;
        }

}
