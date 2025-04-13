using System;
using System.Collections.Generic;

namespace LeetCode
{
    // 1 2 3 4 5 6 7 8  k=3
    public class _532数组中的k_diff数对
    {
        public class Solution
        {
            public int FindPairs(int[] nums, int k)
            {
                if (k < 0) return 0;
                var res = 0;

                if (nums.Length <= 1) return 0;

                Array.Sort(nums);

                var map = new Dictionary<int, int>();

                var i = 0;
                var j = 1;
                while (true)
                {
                    if (i >= nums.Length || j >= nums.Length)
                        break;
                    if (Math.Abs(nums[i] - nums[j]) < k)
                    {
                        j++;
                    }
                    else if (Math.Abs(nums[i] - nums[j]) > k)
                    {
                        i++;
                        if (i == j) j++;
                    }
                    else
                    {
                        if (!map.ContainsKey(nums[i]))
                        {
                            res++;
                            map[nums[i]] = nums[j];
                        }

                        i++;
                        j++;
                    }
                }

                return res;
            }
        }
    }
}