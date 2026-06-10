using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _239滑动窗口最大值
    {
        
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            LinkedList<int> list = new LinkedList<int>();
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                if(list.Count> 0 && list.First.Value < i -k)
                    list.RemoveFirst();
                while (list.Count > 0 && nums[list.Last.Value] <= nums[i])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);
                if(i >= k-1)
                    res.Add(nums[list.First.Value]);
            }
            return res.ToArray();
        }
    }
}
