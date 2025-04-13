namespace LeetCode
{
    public class _566重塑矩阵
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var h = mat.Length;
            var w = mat[0].Length;
            if (r * c != h * w) return mat;

            var res = new int[r][];
            for (var i = 0; i < r; i++)
            {
                res[i] = new int[c];
                for (var j = 0; j < c; j++)
                {
                    var count = i * c + j + 1;
                    var oriI = (count - 1) / w;
                    var oriJ = count <= w ? count - 1 : count % w == 0 ? w - 1 : count % w - 1;
                    res[i][j] = mat[oriI][oriJ];
                }
            }

            return res;
        }
    }
}