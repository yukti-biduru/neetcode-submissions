public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
            int[] row = new int[9]; 
            int[] col = new int[9];
            int[] squ = new int[9];
            for (int r=0; r<9; r++)
            {
                for(int c=0; c<9; c++)
                {
                    if (board[r][c] == '.')
                        continue;
                    int val = int.Parse(board[r][c].ToString());
                    if ((row[r] & (1 << val)) > 0)
                        return false;
                    if ((col[c] & (1 << val)) > 0)
                        return false;
                    if ((squ[r / 3 * 3 + c / 3] & (1 << val)) > 0)
                        return false;

                    row[r] |= (1 << val);
                    col[c] |= (1 << val);
                    squ[r / 3 * 3 + c / 3] |= (1 << val);
                }
            }
            return true;
        }
    }

