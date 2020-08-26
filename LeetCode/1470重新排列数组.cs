using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1470重新排列数组
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var res = new int[nums.Length];
            bool b = true;
            int m = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if(b)
                {
                    res[i] = nums[m];
                    m++;
                }
                else
                {
                    res[i] = nums[n];
                    n++;
                }
                b = !b;
            }
            return res;
        }
    }
}
