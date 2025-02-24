using System;

namespace LeetCode
{
    public class _495提莫攻击
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            var result = 0;
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (i != timeSeries.Length - 1)
                {
                    result += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
                }
                else
                {
                    result += duration;
                }
            }
            return result;
        }
    }
}