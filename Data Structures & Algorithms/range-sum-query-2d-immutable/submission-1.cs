public class NumMatrix {
    private int[][] ps;
    public NumMatrix(int[][] matrix) {
        // calculate the prefix sum 
        ps = matrix; 
        
        for(int i=1; i<ps.Length; i++)
        {
            ps[i][0] += ps[i-1][0];
        }
        
        for(int j=1; j<ps[0].Length; j++)
        {
            ps[0][j] += ps[0][j-1];
        }

        for(int i=1; i<ps.Length; i++)
        {
            for(int j=1; j < ps[0].Length; j++)
            {
                ps[i][j] += ps[i-1][j] + ps[i][j-1] - ps[i-1][j-1]; 
            }
        }    

    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(row1 == 0 && col1 == 0)
        {
            return ps[row2][col2];
        }
        else if (row1 == 0 && col1 != 0)
        {
            return ps[row2][col2] - ps[row2][col1-1];
        }
        else if (row1 != 0 && col1 == 0)
        {
            return ps[row2][col2] - ps[row1-1][col2];
        }    
        else 
            return ps[row2][col2] - ps[row1-1][col2] - ps[row2][col1-1] + ps[row1-1][col1-1];
    }
}
