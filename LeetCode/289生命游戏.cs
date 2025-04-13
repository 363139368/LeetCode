namespace LeetCode
{
    public class _289生命游戏
    {
        public void GameOfLife(int[][] board)
        {
            for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
            {
                var cur = board[i][j];
                var c = GetLifeCount(board, i, j);
                if (cur == 1)
                {
                    if (c == 2 || c == 3) board[i][j] |= 1 << 1;
                }
                else
                {
                    if (c == 3) board[i][j] |= 1 << 1;
                }
            }

            for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
                if (((board[i][j] >> 1)　& 1) == 1)
                    board[i][j] = 1;
                else
                    board[i][j] = 0;
        }

        public bool IsLife(int[][] board, int i, int j)
        {
            if (i >= 0 && i < board.Length && j >= 0 && j < board[i].Length)
                if ((board[i][j]　& 1) == 1)
                    return true;

            return false;
        }

        public int GetLifeCount(int[][] board, int i, int j)
        {
            var res = 0;
            // left top
            if (IsLife(board, i - 1, j - 1)) res++;
            // top
            if (IsLife(board, i - 1, j)) res++;
            //right top
            if (IsLife(board, i - 1, j + 1)) res++;
            //left
            if (IsLife(board, i, j - 1)) res++;
            // right
            if (IsLife(board, i, j + 1)) res++;
            //left down
            if (IsLife(board, i + 1, j - 1)) res++;
            //down
            if (IsLife(board, i + 1, j)) res++;
            //right down
            if (IsLife(board, i + 1, j + 1)) res++;

            return res;
        }
    }
}