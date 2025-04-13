using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _448找到所有数组中消失的数字
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var cur = Math.Abs(nums[i]) - 1;
                nums[cur] = Math.Abs(nums[cur]) * -1;
            }

            var result = new List<int>();
            for (var i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    result.Add(i + 1);

            return result;
        }
    }
}