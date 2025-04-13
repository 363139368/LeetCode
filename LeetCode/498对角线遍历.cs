namespace LeetCode
{
    public class _498对角线遍历
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            var high = mat.Length;
            var width = mat[0].Length;
            var result = new int[high * width];
            var curIndex = 0;
            if (high == 1)
            {
                for (var i = 0; i < mat[0].Length; i++) result[i] = mat[0][i];
                return result;
            }

            if (width == 1)
            {
                for (var i = 0; i < mat.Length; i++)
                for (var j = 0; j < mat[i].Length; j++)
                    result[i] = mat[i][j];

                return result;
            }

            var posX = 0;
            var posY = 0;
            var target = ETarget.eTarget_Up;
            while (curIndex < result.Length)
            {
                result[curIndex] = mat[posX][posY];
                curIndex++;
                switch (target)
                {
                    case ETarget.eTarget_Up:
                        if (posX == 0 && posY == width - 1)
                        {
                            target = ETarget.eTarget_Down;
                            posX++;
                        }
                        else if (posX == 0)
                        {
                            target = ETarget.eTarget_Down;
                            posY++;
                        }
                        else if (posY == width - 1)
                        {
                            target = ETarget.eTarget_Down;
                            posX++;
                        }
                        else
                        {
                            posX--;
                            posY++;
                        }

                        break;
                    case ETarget.eTarget_Down:
                        if (posX == high - 1 && posY == 0)
                        {
                            target = ETarget.eTarget_Up;
                            posY++;
                        }
                        else if (posX == high - 1)
                        {
                            target = ETarget.eTarget_Up;
                            posY++;
                        }
                        else if (posY == 0)
                        {
                            target = ETarget.eTarget_Up;
                            posX++;
                        }
                        else
                        {
                            posX++;
                            posY--;
                        }

                        break;
                }
            }

            return result;
        }
    }
}