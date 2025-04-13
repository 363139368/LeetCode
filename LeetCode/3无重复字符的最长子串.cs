using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    ///     216ms
    ///     25.5mb
    /// </summary>
    public class _3无重复字符的最长子串
    {
        public int LengthOfLongestSubstring_2024(string s)
        {
            if (s.Length == 0) return 0;
            var left = 0;
            var right = 0;
            var sum = 0;
            var map = new Dictionary<char, int>(128);
            map[s[0]] = 1;
            sum++;
            var res = 1;
            while (true)
            {
                if (right >= s.Length) break;
                var nextRight = right + 1;
                if (nextRight >= s.Length) break;
                if (map.ContainsKey(s[nextRight]))
                {
                    map.Remove(s[left]);
                    left++;
                    sum--;
                }
                else
                {
                    map[s[nextRight]] = 1;
                    right = nextRight;
                    sum++;
                    if (sum > res) res = sum;
                }
            }

            return res;
        }

        public int LengthOfLongestSubstring_old(string s)
        {
            var sum = 0;
            var hash = new HashSet<int>();
            for (var i = 0; i < s.Length; i++)
            {
                var cur = s[i];
                if (!hash.Contains(cur))
                {
                    hash.Add(cur);
                }
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
        ///     128ms
        ///     24.9mb
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            var sum = 0;
            var start = 0;
            var end = 0;
            var temp16 = 0;
            var temp32 = 0;
            var temp48 = 0;
            var temp64 = 0;
            var temp80 = 0;
            var temp96 = 0;
            var temp112 = 0;
            var temp128 = 0;
            while (start < s.Length && end < s.Length)
            {
                int cur = s[end];
                if (cur <= 16)
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