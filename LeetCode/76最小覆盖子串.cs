using System;

namespace LeetCode
{
    public class _76最小覆盖子串
    {
        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length)
                return string.Empty;
            if (s.Length == 1)
                return s.Equals(t) ? s : string.Empty;
            if (t.Length == 1)
            {
                if (s.IndexOf(t, StringComparison.Ordinal) >= 0)
                    return t;
                return string.Empty;
            }

            var count = t.Length;
            var statistics = new int[128];
            for (var i = 0; i < t.Length; i++) statistics[t[i]]++;
            var cur = new int[128];
            var curCount = 0;
            int l = 0, r = 1;
            var firstL = (int)s[l];
            cur[firstL]++;
            if (cur[firstL] <= statistics[firstL])
                curCount++;

            var firstR = (int)s[r];
            cur[firstR]++;
            if (cur[firstR] <= statistics[firstR])
                curCount++;

            var lastHead = 0;
            var lastCount = 0;
            var leftLimit = s.Length - t.Length;
            while (l <= leftLimit && r < s.Length)
                if (curCount >= count) //左指针移动
                {
                    if (lastCount == 0 || r - l < lastCount)
                    {
                        lastHead = l;
                        lastCount = r - l + 1;
                    }

                    cur[s[l]]--;
                    ++l;
                    curCount = StatisticsCurCount(statistics, cur);
                }
                else //右指针移动
                {
                    ++r;
                    if (r >= s.Length)
                        break;
                    cur[s[r]]++;
                    if (cur[s[r]] <= statistics[s[r]])
                        curCount++;
                }

            return s.Substring(lastHead, lastCount);
        }

        private int StatisticsCurCount(int[] templete, int[] cur)
        {
            var res = 0;
            for (var i = 0; i < templete.Length; i++) res += cur[i] > templete[i] ? templete[i] : cur[i];

            return res;
        }
    }
}