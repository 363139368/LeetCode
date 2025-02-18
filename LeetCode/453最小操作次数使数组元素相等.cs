using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _453最小操作次数使数组元素相等
    {
        public int MinMoves(int[] nums)
        {
            var min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                min = Math.Min(min, nums[i]);
            }
            var res = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res += (nums[i] - min);
            }
            return res;
        }
    }
}