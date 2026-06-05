using System.Collections.Generic;

namespace LeetCode
{
    public class _438找到字符串中所有字母异位词 {
        public IList<int> FindAnagrams(string s, string p) {
            var res = new List<int>();

            if (p.Length > s.Length)
            {
                return res;
            }
            
            int[] pv = new int[26];

            for (int i = 0; i < p.Length; i++)
            {
                pv[p[i] - 'a']++;
            }
            
            int[] win = new int[26];

            for (int i = 0; i < p.Length; i++)
            {
                win[s[i] - 'a']++;
            }

            if (CompareArray(pv, win))
            {
                res.Add(0);
            }

            for (int i = 1; i < s.Length; i++)
            {
                if(i + p.Length > s.Length)break;

                var tmp = s[i - 1];
                var tmpp = tmp - 'a';
                win[tmpp]--;
                var tmppp = i + p.Length - 1;
                var tmpppp = s[tmppp];
                var tmppppp = tmpppp - 'a';
                win[tmppppp]++;
                if (CompareArray(pv, win))
                {
                    res.Add(i);
                }
            }
            
            return res;
        }

        public bool CompareArray(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])return false;
            }
            return true;
        }

    }
}