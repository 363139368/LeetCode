using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _34在排序数组中查找元素的第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var res = new int[] { -1, -1 };
            int l = 0, r = nums.Length - 1;
            while (nums[l] <= target && nums[r] >= target)
            {

            }
            return null;
        }
    }
}
