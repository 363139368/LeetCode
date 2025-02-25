namespace LeetCode
{
    public class _419棋盘上的战舰
    {
        private char dot = '.';
        private char x = 'X';
        
        public bool IsX(char c)
        {
            return c == x;
        }

        public bool IsDot(char c)
        {
            return c ==dot;
        }

        public int CountBattleships2(char[][] board)
        {
            int result = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    var cur = board[i][j];
                    if (IsX(cur))
                    {
                        bool iPre = i > 0 ? IsDot(board[i - 1][j]) : true;
                        bool jPre = j > 0 ? IsDot(board[i][j - 1]) : true;
                        if (iPre && jPre)
                            result++;
                    }
                }
            }
            return result;
        }
        
        public int CountBattleships(char[][] board)
        {
            int n = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (IsX(board[i][j]))
                    {
                        n++;
                        TipN(board, i, j);
                    }
                }
            }
            return n;
        }

        public void TipN(char[][] board,int x , int y)
        {
            board[x][y] =dot;

            var i = x-1;
            while (true)
            {
                var tmp = GetChar(board,i,y);
                if (IsX(tmp))
                {
                    board[i][y] = dot;
                    i--;
                }
                else
                {
                    break;
                }
            }

            i = x + 1;
            while (true)
            {
                var tmp = GetChar(board,i,y);
                if (IsX(tmp))
                {
                    board[i][y] = dot;
                    i++;
                }
                else
                {
                    break;
                }
            }

            i = y - 1;
            while (true)
            {
                var tmp = GetChar(board,x,i);
                if (IsX(tmp))
                {
                    board[x][i] = dot;
                    i--;
                }
                else
                {
                    break;
                }
            }
            i = y + 1;
            while (true)
            {
                var tmp = GetChar(board,x,i);
                if (IsX(tmp))
                {
                    board[x][i] = dot;
                    i++;
                }
                else
                {
                    break;
                }
            }
        }

        public char GetChar(char[][] chars, int x, int y)
        {
            if (x >= chars.Length || x < 0)
            {
                return dot;
            }

            if (y >= chars[x].Length || y < 0)
            {
                return dot;
            }
            return chars[x][y];
        }


    }
}