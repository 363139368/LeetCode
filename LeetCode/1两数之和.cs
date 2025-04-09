using System.Collections.Generic;

namespace LeetCode
{
    public class _1两数之和 {
        public class Solution {
            public int[] TwoSum(int[] nums, int target) {
                Dictionary<int,int> dicV2Index = new Dictionary<int,int>(nums.Length);
                for (int i = 0; i < nums.Length; i++)
                {
                    var cur = nums[i];
                    
                    var offset = target - cur;
                    if (dicV2Index.ContainsKey(offset))
                    {
                        return new int[]{dicV2Index[offset],i};
                    }
                    dicV2Index[cur] = i;
                }
                return null;
            }
        }
    }
}