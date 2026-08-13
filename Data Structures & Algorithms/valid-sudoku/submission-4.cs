public class Solution {
    public bool IsValidSudoku(char[][] board)
            {
            // row-wise
            for (int row=0; row<9; row++)
            {
                List<int> seen = new List<int>();
                for(int j=0; j<9; j++)
                {
                    if (board[row][j] == '.')
                        continue;
                    if (seen.Contains(board[row][j]))
                    {
                        return false;
                    }
                    seen.Add(board[row][j]);
                }
            }

            // col-wise 
            for (int col = 0; col < 9; col++)
            {
                List<int> seen = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][col] == '.')
                        continue;
                    if (seen.Contains(board[j][col]))
                    {
                        return false;
                    }
                    seen.Add(board[j][col]);
                }
            }

            // square wise 
            for(int sq = 0; sq < 9; sq++)
            {
                List<int> seen = new List<int> ();
                for (int i=0; i<3; i++)
                {
                    for(int j=0; j<3; j++)
                    {
                        int row = (sq / 3) * 3 + i;
                        int col = (sq % 3) * 3 + j;

                        if (board[row][col] == '.')
                            continue;
                        if (seen.Contains(board[row][col]))
                            return false;
                        seen.Add(board[row][col]);
                    }
                }
            }
            return true;


        }
            
    }

