using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _128最长连续序列 {
        public class Solution {
            public int LongestConsecutive(int[] nums) {
                if (nums == null || nums.Length == 0)
                    return 0;
                HashSet<int> set = new HashSet<int>(nums);
                int max = int.MinValue;
                var itor = set.GetEnumerator();
                int tmp = 1;
                while (itor.MoveNext())
                {
                    var cur = itor.Current;
                    if(set.Contains(cur - 1))
                        continue;
                    tmp = 1;
                    while (set.Contains(cur+1))
                    {
                        tmp++;
                        cur++;
                    }
                    max = Math.Max(max, tmp);
                }
                return max;
            }


            public int LongestConsecutive1(int[] nums)
            {
                if (nums == null || nums.Length == 0)
                    return 0;
                if (nums.Length == 1) return 1;
                Array.Sort(nums);
                var res = 1;
                var tmp = 1;
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if(nums[i] == nums[i + 1])continue;
                    if (nums[i] == nums[i + 1]-1)
                    {
                        tmp++;
                        res = Math.Max(res, tmp);
                    }
                    else
                    {
                        tmp = 1;
                    }
                }
                return res;
            }
        }
    }
}