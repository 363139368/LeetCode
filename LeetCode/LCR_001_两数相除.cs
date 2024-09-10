using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LCR_001_两数相除
    {

        public int Divide(int a, int b)
        {
            if (a == int.MinValue)
            {
                if (b == 1)
                {
                    return int.MinValue;
                }
                if (b == -1)
                {
                    return int.MaxValue;
                }
            }
            if (b == int.MinValue)
            {
                return a == int.MinValue ? 1 : 0;
            }
            if (a == 0) return 0;
            if (b == 0) return 0;

            bool isSameSymbol = (a >= 0 && b >= 0) || (a < 0 && b < 0);
            if (a > 0)
            {
                a = -a;
            }
            if (b > 0)
            {
                b = -b;
            }
            if (b < a)
            {
                return 0;
            }

            int tmp = b;
            int res = 1;
            while (tmp >= a && tmp + tmp >= a)
            {
                tmp += tmp;
                res+=res;
            }
            return isSameSymbol ? res : -res;
        }
    }
}
