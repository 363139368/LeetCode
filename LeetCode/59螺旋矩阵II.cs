namespace LeetCode
{
    public class _59螺旋矩阵II
    {
        public int[][] GenerateMatrix(int n)
        {
            var res = new int[n][];
            for (var ii = 0; ii < n; ii++) res[ii] = new int[n];

            var circle = 0;
            var eTarget = ETarget.eTarget_Right;
            var i = 0;
            var j = 0;
            var cur = 0;
            var count = n * n;
            while (cur < count)
            {
                cur++;
                if (i >= n || j >= n)
                    break;
                res[i][j] = cur;
                switch (eTarget)
                {
                    case ETarget.eTarget_Right:
                        if (j >= n - circle - 1)
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
                        if (i >= n - 1 - circle)
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