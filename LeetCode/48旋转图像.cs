namespace LeetCode
{
    public class _48旋转图像
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return;
            if (matrix.Length == 1)
                return;
            var n = matrix.Length;
            for (var i = 0; i < n / 2; i++)
            for (var j = 0; j < n; j++)
                (matrix[i][j], matrix[n - i - 1][j]) = (matrix[n - i - 1][j], matrix[i][j]);

            for (var i = 0; i < n; i++)
            for (var j = 0; j < i; j++)
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
        }
    }
}