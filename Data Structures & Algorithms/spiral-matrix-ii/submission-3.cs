public class Solution {
    public int[][] GenerateMatrix(int n) {
        // initialize nxn matrix 
        int[][] res = new int[n][];
        for (int x = 0; x < n; x++)
        {
            res[x] = new int[n];
        }
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };

        int row = 0, col = 0;
        int d = 0;

        for (int val = 1; val <= n * n; val++)
        {
            res[row][col] = val;

            int nextRow = row + dx[d];
            int nextCol = col + dy[d]; 

            if(nextRow < 0 || nextRow == n || nextCol < 0 || nextCol == n || res[nextRow][nextCol] !=0)
            {
                d = (d + 1) % 4;
                nextRow = row + dx[d];
                nextCol= col + dy[d];
            }
            row = nextRow; 
            col = nextCol;
        }
        return res;
    }
}