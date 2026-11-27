public class Solution {
    public int[][] GenerateMatrix(int n) {
        // precompute or directions or two pointer 
        // we take directions  
        int[] dx = {0,1,0,-1};
        int[] dy = {1,0,-1,0}; 
        // d indices = 0,1,2,3

        // create an empty nxn matrix filled with with zero
        int[][] matrix = new int[n][];
        for(int i=0; i<n; i++)
        {
            matrix[i] = new int[n];
        }
        // loop through numbers until n^2
        int di = 0, r=0, c=0, row = 0, col = 0;
        matrix[row][col]=1;
        for(int i=2; i<=n*n; i++)
        {
            // see if you hit a boundary or a filled number and change direction if you do 
            if(row + dx[di]==n || row + dx[di]<0 || col + dy[di]==n || col + dy[di]<0 || matrix[row + dx[di]][col+dy[di]]!=0)
            {
                di = (di+1)%4;
            }
            row = row+dx[di];
            col = col+dy[di];
            matrix[row][col] = i;
        }
        return matrix;
    }
}