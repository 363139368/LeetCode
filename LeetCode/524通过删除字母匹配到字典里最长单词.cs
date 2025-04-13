using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _524通过删除字母匹配到字典里最长单词
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            var array = d.ToArray();
            Array.Sort(array, CompareByLen);

            for (var i = 0; i < array.Length; i++)
            {
                var cur = array[i];

                var sIndex = 0;
                var aIndex = 0;

                while (sIndex < s.Length && aIndex < cur.Length)
                {
                    if (aIndex == cur.Length - 1 && s[sIndex] == cur[aIndex])
                        return cur;

                    if (s[sIndex] == cur[aIndex])
                    {
                        sIndex++;
                        aIndex++;
                    }
                    else
                    {
                        sIndex++;
                    }
                }
            }

            return string.Empty;
        }


        private int CompareByLen(string cur, string next)
        {
            var res = next.Length.CompareTo(cur.Length);
            if (res == 0)
                res = cur.CompareTo(next);
            return res;
        }
    }
}