using System;

namespace LeetCode
{
    public class _11盛最多水的容器
    {
        public class Solution
        {
            public int MaxArea(int[] height)
            {
                var res = 0;
                int i = 0, j = height.Length - 1;
                while (i < j)
                {
                    var h = Math.Min(height[i], height[j]);
                    var w = j - i;
                    res = Math.Max(res, h * w);
                    if (height[i] > height[j])
                        j--;
                    else
                        i++;
                }

                return res;
            }
        }
    }
}