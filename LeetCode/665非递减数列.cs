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
            int down = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    down++;
                    if (down > 1)
                        return false;

                    if (i == 0 || nums[i + 1] >= nums[i - 1])
                        nums[i] = nums[i + 1];
                    else
                        nums[i + 1] = nums[i];

                }
            }
            return true;
        }
    }
}
