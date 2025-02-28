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
        }
    }
}