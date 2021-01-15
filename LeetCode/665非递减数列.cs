using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _665非递减数列
    {
        public bool CheckPossibility(int[] nums)
        {
            bool b = true;
            if(nums[0]>nums[1])
            {
                nums[1] = nums[0];
                b = !b;
            }
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    nums[i] = nums[i - 1];
                    if (!b)
                        return false;
                    else
                        b = !b;
                }

                if (nums[i] > nums[i + 1])
                {
                    nums[i+1] = nums[i];
                    if (!b)
                        return false;
                    else
                        b = !b;
                }
            }

            return true;
        }
    }
}
