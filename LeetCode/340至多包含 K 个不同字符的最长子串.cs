using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _340至多包含_K_个不同字符的最长子串
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            if (k == 0)
                return 0;

            int[] ks = new int[256];

            int left = 0;
            int right = 0;
            int res = 0;
            int tempRes = 0;
            int tempK = 0;
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
