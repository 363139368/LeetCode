using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _283移动零
    {
        public void MoveZeroes(int[] nums)
        {
            var offset = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 0)
                {
                    offset++;
                    continue;
                }

                if (offset > 0)
                {
                    nums[i - offset] = nums[i];
                }


            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (offset > 0 && i + offset + 1 > nums.Length)
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
