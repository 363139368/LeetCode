using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1480一维数组的动态和
    {
        public int[] RunningSum(int[] nums)
        {
            int[] res = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                res[i] = sum;
            }
            return res;
        }
    }
}