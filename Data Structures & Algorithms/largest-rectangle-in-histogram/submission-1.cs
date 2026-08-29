public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
            int n = heights.Length; 
            int[] leftmost = new int[n];
            int[] rightmost = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i=0; i<n; i++)
            {
                leftmost[i] = -1;
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if(stack.Count > 0)
                {
                    leftmost[i] = stack.Peek();
                }
                stack.Push(i);
            }
            stack.Clear(); 

            for (int i=n-1; i>= 0; i--)
            {
                rightmost[i] = n;
                while(stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if(stack.Count > 0)
                {
                    rightmost[i] = stack.Peek();
                }
                stack.Push(i);
            }

            int maxArea = 0; 
            for (int i=0; i<n; i++)
            {
                leftmost[i] += 1;
                rightmost[i] += -1;
                maxArea = Math.Max(maxArea, heights[i] * (rightmost[i] - leftmost[i] + 1));
            }
            return maxArea;
        }
}
