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
            int l = 0;
            int r = s.Length - 1;

            int errorCount = 0;

            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }
                errorCount++;
                break;
            }

            if (errorCount == 0)
                return true;

            int errorL = l;
            int errorR = r;

            bool bl = true;

            l = errorL + 1;
            r = errorR;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                bl = false;
                break;
            }

            if (bl)
                return true;

            bool br = true;
            l = errorL;
            r = errorR - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                br = false;
                break;
            }

            return br;
        }
    }
}
