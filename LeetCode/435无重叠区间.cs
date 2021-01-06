using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int res = 0;
            int[] last = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                var cur = intervals[i];
                if (cur[0] >= last[1])
                {
                    last = cur;
                    continue;
                }
                else
                    res++;
            }
            return res;
        }
    }
}
