using System;
using System.Collections.Generic;

namespace LeetCode
{
    public enum ETarget
    {
        eTarget_None = 0,
        eTarget_Left,
        eTarget_Right,
        eTarget_Up,
        eTarget_Down,
    }

    public class _54螺旋矩阵
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return null;
            }


            var high = matrix.Length;
            var width = matrix[0].Length;
            var circle = 0;
            var eTarget = ETarget.eTarget_Right;
            int i = 0, j = 0;
            int tarI = high / 2, tarJ = width / 2;
            if (high == 1)
            {
                tarI = 0;
                tarJ = width - 1;
            }

            if (width == 1)
            {
                tarI = high - 1;
                tarJ = 0;
            }

            var n = high * width;
            var res = new List<int>(n);

            while (res.Count < n)
            {
                res.Add(matrix[i][j]);
                switch (eTarget)
                {
                    case ETarget.eTarget_Right:
                        if (j >= width - circle - 1)
                        {
                            eTarget = ETarget.eTarget_Down;
                            i++;
                        }
                        else
                        {
                            j++;
                        }

                        break;
                    case ETarget.eTarget_Left:
                        if (j <= circle)
                        {
                            eTarget = ETarget.eTarget_Up;
                            i--;
                        }
                        else
                        {
                            j--;
                        }

                        break;
                    case ETarget.eTarget_Up:
                        if (i <= circle + 1)
                        {
                            eTarget = ETarget.eTarget_Right;
                            circle++;
                            j++;
                        }
                        else
                        {
                            i--;
                        }

                        break;
                    case ETarget.eTarget_Down:
                        if (i >= high - 1 - circle)
                        {
                            eTarget = ETarget.eTarget_Left;
                            j--;
                        }
                        else
                        {
                            i++;
                        }

                        break;
                }
            }

            return res;
        }
    }
}