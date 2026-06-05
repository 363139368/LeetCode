using System;

namespace LeetCode
{
    public class _42接雨水
    {
        public class Solution
        {
            public int Trap(int[] height)
            {
                int[] tmp = new int[height.Length];
                
                int max = 0;
                for (int i = 0; i < height.Length; i++)
                {
                    max = Math.Max(max, height[i]);
                    tmp[i] = max;
                }

                int res = 0;
                max = 0;
                for (int i = height.Length - 1; i >= 0; i--)
                {
                    max = Math.Max(max, height[i]);
                    int min = Math.Min(tmp[i],max);
                    if (min > height[i])
                    {
                        res += min -  height[i];
                    }
                }
                return res;
            }
        }
    }
}