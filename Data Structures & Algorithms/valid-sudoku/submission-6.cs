public class Solution {
    public bool IsValidSudoku(char[][] board)
            {
                            // Go through all values 
            // See if its repeating in its row 
            // see if its repeating in its col 
            // see if its repeating in its square 

            Dictionary<int, HashSet<int>> rows = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> cols = new Dictionary<int, HashSet<int>>();
            Dictionary<string, HashSet<int>> squares = new Dictionary<string, HashSet<int>>();

            for (int r=0; r<9; r++)
            {
                for (int c=0; c<9; c++)
                {
                    if (board[r][c] == '.')
                    {
                        continue;
                    }
                    string squareKey = r / 3 + "," + c / 3;
                    if ((rows.ContainsKey(r) && rows[r].Contains(board[r][c])) || 
                        (cols.ContainsKey(c) && cols[c].Contains(board[r][c])) ||
                        (squares.ContainsKey(squareKey) && squares[squareKey].Contains(board[r][c])))
                    {
                        return false;
                    }

                    if(!rows.ContainsKey(r))
                    {
                        rows[r] = new HashSet<int>();
                    }
                    if (!cols.ContainsKey(c))
                    {
                        cols[c] = new HashSet<int>();
                    }
                    if (!squares.ContainsKey(squareKey))
                    {
                        squares[squareKey] = new HashSet<int>();
                    }

                    rows[r].Add(board[r][c]);
                    cols[c].Add(board[r][c]);
                    squares[squareKey].Add(board[r][c]);
                }
            }
            return true;
            }
    }

