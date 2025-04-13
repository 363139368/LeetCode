using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _15三数之和
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (nums.Length < 3)
                return null;

            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 2; i++)
            {
                var temp = nums[i];
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    if (j != i+1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    if (k != nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }
                    if (temp + nums[j] + nums[k] == 0)
                    {
                        res.Add(new List<int> { temp, nums[j], nums[k] });
                        j++;
                        k--;
                    }
                    else if (temp + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            return res;
        }
    }
}