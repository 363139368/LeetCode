using System;

namespace LeetCode
{
    public class _340至多包含_K_个不同字符的最长子串
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            if (k == 0)
                return 0;

            var ks = new int[256];

            var left = 0;
            var right = 0;
            var res = 0;
            var tempRes = 0;
            var tempK = 0;
            while (left < s.Length)
            {
                if (right >= s.Length)
                {
                    left++;
                    right = left;
                    ks = new int[256];
                    res = Math.Max(res, tempRes);
                    tempK = 0;
                    tempRes = 0;
                    continue;
                }

                if (tempK < k)
                {
                    if (ks[s[right]] == 0)
                    {
                        ks[s[right]] = 1;
                        tempK++;
                    }

                    right++;
                    tempRes++;
                }
                else if (tempK == k)
                {
                    if (ks[s[right]] == 1)
                    {
                        tempRes++;
                        right++;
                    }
                    else
                    {
                        res = Math.Max(res, tempRes);

                        tempK = 0;
                        tempRes = 0;
                        left++;
                        right = left;
                        ks = new int[256];
                    }
                }
            }

            return res;
        }
    }
}