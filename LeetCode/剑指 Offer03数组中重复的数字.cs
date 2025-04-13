using System.Collections.Generic;

namespace LeetCode
{
    public class 剑指_Offer03数组中重复的数字
    {
        public int FindRepeatNumber(int[] nums)
        {
            var hs = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                    return nums[i];
                hs.Add(nums[i]);
            }

            return nums[0];
        }
    }
}