namespace LeetCode
{
    public class _661图片平滑器
    {
        public int[][] ImageSmoother(int[][] img)
        {
            var result = new int[img.Length][];
            var iMax = img.Length;
            for (int i = 0; i < iMax; i++)
            {
                var jMax = img[i].Length;
                result[i] = new int[jMax];
                for (int j = 0; j < jMax; j++)
                {
                    var sum = img[i][j];
                    var count = 1;
                    
                    if (j - 1 >= 0)
                    {
                        sum += img[i][j - 1];
                        count++;
                    }

                    if (j + 1 < jMax)
                    {
                        sum += img[i][j + 1];
                        count++;
                    }
                    
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        sum += img[i - 1][j - 1];
                        count++;
                    }
                    if (i - 1 >= 0)
                    {
                        sum += img[i - 1][j];
                        count++;
                    }

                    if (i - 1 >= 0 && j + 1 < jMax)
                    {
                        sum += img[i - 1][j + 1];
                        count++;
                    }
                    
                    if (i + 1 < iMax && j + 1 < jMax)
                    {
                        sum += img[i + 1][j + 1];
                        count++;
                    }

                    if (i + 1 < iMax)
                    {
                        sum += img[i + 1][j];
                        count++;
                    }
                    
                    if (i + 1 < iMax && j - 1 >= 0)
                    {
                        sum += img[i + 1][j - 1];
                        count++;
                    }

                    result[i][j] = sum / count;
                }
            }
            return result;
        }
    }
}