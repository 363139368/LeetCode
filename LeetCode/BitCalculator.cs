using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BitCalculator
    {
        public int Add(int x, int y)
        {
            int res = x;
            while (y != 0)
            {
                var tmp = res ^ y;
                y = ((y & res) << 1);
                res = tmp;
            }
            return res;
        }

        public int Subtract(int x, int y) 
        { 
            return Add(x,Negation(y));
        }

        public int Negation(int x)
        {
            return Add(~x, 1);
        }

        public int Multiply(int x, int y)
        {
            bool isNeg = (x > 0 && y < 0) || (x < 0 && y > 0);
            if (x < 0) { x = Negation(x); }
            if (y < 0) { y = Negation(y); }
            var res = 0;
            while (y != 0)
            {
                if ((y & 1) > 0)
                {
                    res = Add(res, x);
                }
                x <<= 1;
                y >>= 1;
            }
            return isNeg ? Negation(res) : res;
        }
    }
}
