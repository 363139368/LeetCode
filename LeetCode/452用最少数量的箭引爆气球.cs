using System;

namespace LeetCode
{
    public class _452用最少数量的箭引爆气球
    {
        public static int Compare(int[] a1, int[] a2)
        {
            return a1[1].CompareTo(a2[1]);
        }

        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 0)
                return 0;
            if (points.Length == 1)
                return 1;
            Array.Sort(points, Compare);
            var res = 1;
            var lastX = points[0][1];
            for (var i = 1; i < points.Length; i++)
            {
                var cur = points[i];
                if (lastX >= cur[0] && lastX <= cur[1])
                    continue;
                res++;
                lastX = cur[1];
            }

            return res;
        }
    }
}