using System.Collections.Generic;

namespace LeetCode
{
    public class _205同构字符串
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var map = new Dictionary<char, int>();
            var ints = new int[s.Length];
            var ii = 1;
            for (var i = 0; i < ints.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map[s[i]] = ii;
                    ii++;
                }

                ints[i] = map[s[i]];
            }

            ii = 1;
            map.Clear();
            for (var i = 0; i < ints.Length; i++)
            {
                if (!map.ContainsKey(t[i]))
                {
                    map[t[i]] = ii;
                    ii++;
                }

                var t1 = ints[i];
                var t2 = map[t[i]];
                if (t1 != t2) return false;
            }

            return true;
        }
    }
}