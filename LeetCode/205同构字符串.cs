using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _205同构字符串
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int[] ints = new int[s.Length];
            var ii = 1;
            for (int i = 0; i < ints.Length; i++)
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
            for (int i = 0; i < ints.Length; i++)
            {
                if (!map.ContainsKey(t[i]))
                {
                    map[t[i]] = ii;
                    ii++;
                }
                var t1 = ints[i];
                var t2 = map[t[i]];
                if (t1 != t2) { return false; }
            }
            return true;
        }
    }
}
