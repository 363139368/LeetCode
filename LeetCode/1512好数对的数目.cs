using System.Collections.Generic;

namespace LeetCode
{
    public class _1512好数对的数目
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var res = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (dic.ContainsKey(cur))
                {
                    var count = dic[cur];
                    res += count;
                    dic[cur] = count + 1;
                }
                else
                {
                    dic[cur] = 1;
                }
            }

            return res;
        }
    }
}