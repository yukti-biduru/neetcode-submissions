public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
            int m = matrix[0].Length;
            for (int r = 0; r < matrix.Length; r++)
            {
                if (matrix[r][m - 1] >= target)
                {
                    for (int c = 0; c < m; c++)
                    {
                        if (matrix[r][c] == target)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
}
