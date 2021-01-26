using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                else
                    return string.Empty;
            }

            int count = t.Length;
            int[] statistics = new int[128];
            for (int i = 0; i < t.Length; i++)
            {
                statistics[(int)t[i]]++;
            }
            int[] cur = new int[128];
            int curCount = 0;
            int l = 0, r = 1;
            var firstL = (int)s[l];
            cur[firstL]++;
            if (cur[firstL] <= statistics[firstL])
                curCount++;

            var firstR = (int)s[r];
            cur[firstR]++;
            if (cur[firstR] <= statistics[firstR])
                curCount++;

            int lastHead = 0;
            int lastCount = 0;
            int leftLimit = s.Length - t.Length;
            while (l <= leftLimit && r < s.Length)
            {
                if (curCount >= count)                 //左指针移动
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
                else                                   //右指针移动
                {
                    ++r;
                    if (r >= s.Length)
                        break;
                    cur[s[r]]++;
                    if (cur[s[r]] <= statistics[s[r]])
                        curCount++;
                }
            }

            return s.Substring(lastHead, lastCount);
        }

        private int StatisticsCurCount(int[] templete, int[] cur)
        {
            int res = 0;
            for (int i = 0; i < templete.Length; i++)
            {
                res += (cur[i] > templete[i] ? templete[i] : cur[i]);
            }

            return res;
        }
    }
}
