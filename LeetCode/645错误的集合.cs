﻿using System;

namespace LeetCode
{
    public class _645错误的集合
    {
        public int[] FindErrorNums(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return nums;
            Array.Sort(nums);
            for (var i = 1; i < nums.Length; i++)
                if (nums[i] == nums[i - 1])
                    return new[] { nums[i], nums[i] + 1 };

            return null;
        }
    }
}