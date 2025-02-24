using System;

namespace LeetCode
{
    public class _41缺失的第一个正数
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                var curIndex = cur - 1;
                if (cur >= 1 && cur <= nums.Length && cur != i+1 && nums[i] != nums[curIndex])
                {
                    (nums[i], nums[curIndex]) = (nums[curIndex], nums[i]);
                    i--;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
    }
}