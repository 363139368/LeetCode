using System;

namespace LeetCode
{
    public class _396旋转函数 {
        public int MaxRotateFunction(int[] nums)
        {
            var sum = 0;
            var f = 0;
            var n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
                f += (nums[i] * i);
            }

            var max = f;

            for (int i = 1; i < n; i++)
            {
                var tmp = f + sum - n * nums[n - i];
                max = Math.Max(max, tmp);
                f = tmp;
            }
            return max;
        }
    }
}