using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _69x的平方根
    {
        public int MySqrt(int x)
        {
            int res = x;
            int min = 0;
            int max = x;
            while (true)
            {
                var product = res * res;
                if (product > x)
                {
                    res /= 2;
                }
                else if (product < x)
                {
                    var temp = (int)(res * 1.5f);
                    if (temp == res)
                        break;
                    else
                        res = temp;
                }
                else
                {
                    break;
                }
            }

            return res;
        }
    }
}
