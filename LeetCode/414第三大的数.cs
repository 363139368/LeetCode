using System;

namespace LeetCode
{
    public class _414第三大的数
    {
        public int ThirdMax(int[] nums)
        {
            int? max1 = null;
            int? max2 = null;
            int? max3 = null;

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (max1 != null && num == max1) continue;
                if (max2 != null && num == max2) continue;
                if (max3 != null && num == max3) continue;


                if (max1 == null || num > max1.Value)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if (max2 == null || num > max2.Value)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (max3 == null || num > max3.Value)
                {
                    max3 = num;
                }
            }

            if (max3 != null)
                return max3.Value;
            if (max1 != null)
                return max1.Value;
            return 0;
        }
    }
}