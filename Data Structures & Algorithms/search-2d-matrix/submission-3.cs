public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
            int rows = matrix.Length; 
            int cols = matrix[0].Length;

            int top = 0, bottom = rows - 1;
            int row = 0;

            while (top <= bottom)
            {
                row = (top + bottom) / 2;
                if(target > matrix[row][cols-1])
                {
                    top = row + 1;
                }
                else if (target < matrix[row][0])
                {
                    bottom = row - 1;
                }
                else
                {
                    break;
                }
            }

            if (top > bottom)
            {
                return false;
            }

            int l = 0, r = cols - 1; 
            while (l<=r)
            {
                int m = (l + r) / 2;
                if (matrix[row][m] > target)
                {
                    r = m - 1; 
                }
                else if (matrix[row][m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
}
