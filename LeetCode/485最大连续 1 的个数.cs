using System;

namespace LeetCode
{
    public class _485最大连续_1_的个数
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            bool flag = false;
            int result = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (cur == 0)
                {
                    flag = false;
                    count = 0;
                }
                else
                {
                    if (flag)
                    {
                        count++;
                        result = Math.Max(result, count);
                    }
                    else
                    {
                        flag = true;
                        count = 1;
                        result = Math.Max(result, count);
                    }
                }
            }

            return result;
        }
    }
}