using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class 剑指_Offer03数组中重复的数字
    {
        public int FindRepeatNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                    return nums[i];
                hs.Add(nums[i]);
            }

            return nums[0];
        }
    }
}
