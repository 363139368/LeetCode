using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _442数组中重复的数据
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var cur = Math.Abs(nums[i]);
                if (nums[cur - 1] > 0)
                    nums[cur - 1] *= -1;
                else
                    result.Add(cur);
            }

            return result;
        }
    }
}