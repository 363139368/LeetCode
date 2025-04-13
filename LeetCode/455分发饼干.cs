using System;

namespace LeetCode
{
    public class _455分发饼干
    {
        //g 胃口值 s 饼干大小
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var indexG = 0;
            var indexS = 0;

            var res = 0;
            while (indexG < g.Length && indexS < s.Length)
                if (s[indexS] >= g[indexG])
                {
                    res++;
                    indexG++;
                    indexS++;
                }
                else
                {
                    indexS++;
                }

            return res;
        }
    }
}