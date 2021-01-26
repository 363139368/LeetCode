using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _680验证回文字符串Ⅱ
    {
        public bool ValidPalindrome(string s)
        {
            bool res = true;
            int l = 0;
            int r = s.Length - 1;

            int errorCount = 0;

            int errorL = 0;
            int errorR = 0;

            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                if (errorCount >= 1)
                    res = false;

                errorCount++;


            }

            return res;
        }
    }
}
