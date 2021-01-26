using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _633平方数之和
    {
        public bool JudgeSquareSum(int c)
        {
            int l = 0;
            int r = (int)Math.Sqrt(c);
            while (l != r)
            {
                var temp = l * l + r * r;
                if (temp == c)
                    return true;
                else if (temp > c)
                    r--;
                else
                    l++;
            }
            return l * l + r * r == c;
        }
    }
}
