using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1512好数对的数目
    {
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (dic.ContainsKey(cur))
                {
                    int count = dic[cur];
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