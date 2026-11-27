public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0, n = mat.Length; 
        for(int i=0; i<n; i++)
        {
            sum += mat[i][i] + mat[i][n-1-i];
            if(i==n-1-i)
            {
                sum -= mat[i][i];
            }
        }
        return sum;
    }
}