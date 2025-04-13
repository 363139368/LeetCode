using System;

namespace LeetCode
{
    public class _598区间加法_II
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            if (ops == null || ops.Length == 0)
                return m * n;
            var minX = int.MaxValue;
            var minY = int.MaxValue;
            for (var i = 0; i < ops.Length; i++)
            {
                var curr = ops[i];
                minX = Math.Min(minX, curr[0]);
                minY = Math.Min(minY, curr[1]);
            }

            return minX * minY;
        }
    }
}