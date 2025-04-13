using System.Collections.Generic;

namespace LeetCode
{
    public class _697数组的度
    {
        public int FindShortestSubArray(int[] nums)
        {
            var count = 0;
            var len = 0;
            var dict = new Dictionary<int, Info>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.TryGetValue(nums[i], out var info))
                {
                    info = new Info { Value = nums[i], Count = 1, StartIndex = i, EndIndex = i };
                    dict[nums[i]] = info;
                }
                else
                {
                    info.Count++;
                    info.EndIndex = i;
                }

                if (info.Count > count)
                {
                    count = info.Count;
                    len = info.EndIndex - info.StartIndex;
                }
                else if (info.Count == count && info.EndIndex - info.StartIndex < len)
                {
                    len = info.EndIndex - info.StartIndex;
                }
            }

            return len + 1;
        }

        private class Info
        {
            public int Count;
            public int EndIndex;
            public int StartIndex;
            public int Value;
        }
    }
}