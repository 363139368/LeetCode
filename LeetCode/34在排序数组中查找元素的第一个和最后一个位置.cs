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
            Console.WriteLine(FindDown(nums, target));
            return null;
            var res = new int[] { -1, -1 };
            int l = 0, r = nums.Length - 1;
            while (nums[l] <= target && nums[r] >= target)
            {

            }
            return null;
        }

        private int FindDown(int[] nums, int target)
        {
            int l, r, m;
            l = 0;
            r = nums.Length - 1;
            while (l < r)
            {
                m =  (r + l) / 2;
                if (nums[m] >= target)
                    r = m;
                else 
                    l = m + 1;
            }

            if (nums[l] == target)
                return l;
            else
                return -1;
        }

        private int FindUp(int[] nums, int target, int left)
        {
            int l, r, m;
            l = 0;
            r = nums.Length - 1;
            while (l < r)
            {
                m = (r + l) / 2;
                if (nums[m] > target)
                    l = m + 1;
                else
                    r = m;
            }

            if (nums[l] == target)
                return l;
            else
                return -1;
        }
    }
}
