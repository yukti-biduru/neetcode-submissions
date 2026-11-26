public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
//        int[] leftMax = new int[n]; 
        int[] rightMax = new int[n];

        rightMax[n-1] = height[n-1];
        for(int i=n-2; i>=0; i--)
        {
            rightMax[i] = Math.Max(height[i], rightMax[i+1]);
            
        } 
        int rainwater = 0;
        int leftMax = height[0];
        for(int i=0; i<n; i++)
        {
            leftMax = Math.Max(height[i], leftMax);
            if(leftMax !=0 && rightMax[i] != 0)
                rainwater += Math.Min(leftMax, rightMax[i]) - height[i];
        }
        return rainwater;
    }
}
