namespace LeetCode
{
    public class _73矩阵置零
    {
        // public void SetZeroes(int[][] matrix)
        // {
        //     int firstI = -1;
        //     int firstJ = -1;
        //     int horizontal = 1 << 0;
        //     int vertical = 1 << 1;
        //     for (int i = 0; i < matrix.Length; i++)
        //     {
        //         for (int j = 0; j < matrix[i].Length; j++)
        //         {
        //             if (matrix[i][j] == 0)
        //             {
        //                 if (firstI == -1)
        //                 {
        //                     firstI = i;
        //                     firstJ = j;
        //                     matrix[i][j] = horizontal | vertical;
        //                 }
        //                 else
        //                 {
        //                     matrix[firstI][j] |= vertical;
        //                     matrix[i][firstJ] |= horizontal;
        //                 }
        //             }
        //         }
        //     }
        //
        //     if (firstI < 0) return;
        //
        //     for (int i = 0; i < matrix.Length; i++)
        //     {
        //         if (i == firstI) continue;
        //         for (int j = 0; j < matrix[i].Length; j++)
        //         {
        //             if (j == firstJ) continue;
        //         }
        //     }
        // }
    }
}