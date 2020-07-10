using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 216ms
    /// 25.5mb
    /// </summary>
    public class _3无重复字符的最长子串
    {
        public int LengthOfLongestSubstring_old(string s)
        {
            int sum = 0;
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < s.Length; i++)
            {
                var cur = s[i];
                if (!hash.Contains(cur))
                    hash.Add(cur);
                else
                {
                    sum = hash.Count > sum ? hash.Count : sum;
                    if (hash.Count > 1)
                    {
                        i -= hash.Count;
                        hash.Clear();
                    }
                }
            }
            sum = hash.Count > sum ? hash.Count : sum;
            return sum;
        }
        /// <summary>
        /// 128ms
        /// 24.9mb
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int sum = 0;
            int start = 0;
            int end = 0;
            int temp16 = 0;
            int temp32 = 0;
            int temp48 = 0;
            int temp64 = 0;
            int temp80 = 0;
            int temp96 = 0;
            int temp112 = 0;
            int temp128 = 0;
            while (start < s.Length && end < s.Length)
            {
                int cur = s[end];
                if(cur <= 16)
                {
                    cur = 1 << cur;
                    if ((temp16 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp16 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 32)
                {
                    cur -= 16;
                    cur = 1 << cur;
                    if ((temp32 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp32 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 48)
                {
                    cur -= 32;
                    cur = 1 << cur;
                    if ((temp48 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp48 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 64)
                {
                    cur -= 48;
                    cur = 1 << cur;
                    if ((temp64 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp64 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 80)
                {
                    cur -= 64;
                    cur = 1 << cur;
                    if ((temp80 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp80 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 96)
                {
                    cur -= 80;
                    cur = 1 << cur;
                    if ((temp96 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp96 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 112)
                {
                    cur -= 96;
                    cur = 1 << cur;
                    if ((temp112 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp112 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
                else if (cur <= 128)
                {
                    cur -= 112;
                    cur = 1 << cur;

                    if ((temp128 & cur) == cur)
                    {
                        temp16 = 0;
                        temp32 = 0;
                        temp48 = 0;
                        temp64 = 0;
                        temp80 = 0;
                        temp96 = 0;
                        temp112 = 0;
                        temp128 = 0;

                        start++;
                        end = start;
                    }
                    else
                    {
                        temp128 |= cur;
                        end++;
                        var offset = end - start;
                        sum = offset > sum ? offset : sum;
                    }
                }
            }
            return sum;
        }
    }
}
