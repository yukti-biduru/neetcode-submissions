public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // check all rows and columns 
        HashSet<int> row_vals = new HashSet<int>();
        HashSet<int> col_vals = new HashSet<int>();
        for (int i=0; i<9; i++)
        {   
            row_vals = new HashSet<int>();
            col_vals = new HashSet<int>();
            for (int j=0; j<9; j++)
            {
                if(board[i][j] != '.')
                {
                    if(row_vals.Contains(board[i][j]))
                    {
                        Console.WriteLine(board[i][j]);
                        return false;
                    }
                    row_vals.Add(board[i][j]);
                }
                
                if (board[j][i] != '.')
                { 
                    if(col_vals.Contains(board[j][i]))
                    {
                        Console.WriteLine(board[j][i]);
                        return false;
                    }
                    col_vals.Add(board[j][i]);
                }
            }
        }
        
        // check all 3x3 grids 
        for (int m = 0; m<9; m++)
        {
            HashSet<int> box_vals = new HashSet<int>();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    int row = (m/3)*3+i;
                    int col = (m%3)*3+j;
                    if(board[row][col] != '.')
                    {
                        if(box_vals.Contains(board[row][col]))
                        {
                            Console.WriteLine(board[row][col]);
                            return false;
                        }
                        box_vals.Add(board[row][col]);
                    }
                }
            }
        }
        return true;    
    }
}
