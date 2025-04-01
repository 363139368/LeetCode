namespace LeetCode
{
    public class _240搜索二维矩阵II {
        public class Solution {
            public bool SearchMatrix(int[][] matrix, int target)
            {
                var h = matrix.Length-1;
                var w = matrix[0].Length-1;

                var i = h;
                var j = 0;
                while (i >= 0 && j <= w)
                {
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }

                    if (target < matrix[i][j])
                    {
                        i--;
                    }
                    else
                    {
                        j++;
                    }
                }
                return false;
            }
        }
    }
}