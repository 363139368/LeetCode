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
            int left = 0;
            int right = 1;
            int res = 0;
            while (left <= nums.Length - 2)
            {
                if (right > nums.Length - 1) break;
                int tmpSum = sums[right] - sums[left];
                if (tmpSum == k) 
                {
                    res++;
                    left++; 
                    right++;
                }
                else if (tmpSum > k)
                {
                    if (right - 1 > left)
                        right--;
                    else
                        left++;
                }
                else
                {
                    if (right == nums.Length - 1) left++;
                    else right++;
                }
            }
            return res;
        }
    }
}
