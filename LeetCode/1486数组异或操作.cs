using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1486数组异或操作
    {
        public int XorOperation(int n, int start)
        {
            var nums = new int[n];
            nums[0] = start;
            int res = start;
            for (int i = 1; i < nums.Length; i++)
            {
                var cur = start + 2 * i;
                nums[i] = cur;
                res ^= cur;
            }
            return res;
        }
    }
}