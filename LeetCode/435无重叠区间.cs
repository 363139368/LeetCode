using System;

namespace LeetCode
{
    public class _435无重叠区间
    {
        public static int Compare(int[] a1, int[] a2)
        {
            return a1[1].CompareTo(a2[1]);
        }

        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return 0;
            Array.Sort(intervals, Compare);
            var res = 0;
            var last = intervals[0];
            for (var i = 1; i < intervals.Length; i++)
            {
                var cur = intervals[i];
                if (cur[0] >= last[1])
                    last = cur;
                else
                    res++;
            }

            return res;
        }
    }
}