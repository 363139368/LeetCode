using System.Collections.Generic;

namespace LeetCode
{
    public class _1两数之和
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var dicV2Index = new Dictionary<int, int>(nums.Length);
                for (var i = 0; i < nums.Length; i++)
                {
                    var cur = nums[i];

                    var offset = target - cur;
                    if (dicV2Index.ContainsKey(offset)) return new[] { dicV2Index[offset], i };
                    dicV2Index[cur] = i;
                }

                return null;
            }
        }
    }
}