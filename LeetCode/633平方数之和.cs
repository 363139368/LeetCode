using System;

namespace LeetCode
{
    public class _633平方数之和
    {
        public bool JudgeSquareSum(int c)
        {
            var l = 0;
            var r = (int)Math.Sqrt(c);
            while (l != r)
            {
                var temp = l * l + r * r;
                if (temp == c)
                    return true;
                if (temp > c)
                    r--;
                else
                    l++;
            }

            return l * l + r * r == c;
        }
    }
}