using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _560和为K的子数组
    {
        public int SubarraySum(int[] nums, int k)
        {
            Array.Sort(nums);
            int[] sums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    sums[i] = nums[i];
                }
                else
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }
            int res = 0;
            for (int left = 0; left < nums.Length - 1; left++)
            {

                for (int right = left + 1; left < nums.Length; right++)
                {
                    var tmp = sums[right] - sums[left];
                    if (tmp == k)
                    {
                        res++;
                        break;
                    }
                    else if(tmp > k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            return res;
        }
    }
}
