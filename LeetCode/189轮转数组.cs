using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _189轮转数组
    {
        public void Rotate(int[] nums, int k)
        {
            if (k == 0)
            {
                return;
            }
            if (nums.Length <= 1)
            {
                return ;
            }
            if(k > nums.Length)
            {
                k = k%nums.Length;
            }
            int jMax = nums.Length % k == 0 ? nums.Length / k : nums.Length / k + 1;
            jMax *= k;
            for (int i = 0; i < k; i++)
            {
                for (int j = i+k; j < jMax; j+=k)
                {
                    var nextIndex = j;
                    if (j >= nums.Length)
                    {
                        nextIndex = j % nums.Length;
                    }
                    (nums[nextIndex], nums[i]) = (nums[i], nums[nextIndex]);
                }
            }
        }
    }
}
