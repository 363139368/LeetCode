namespace LeetCode
{
    public class _34在排序数组中查找元素的第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var first = -1;
            var last = -1;
            var l = 0;
            var r = nums.Length - 1;
            var m = (r - l) / 2 + l;
            while (l <= r)
            {
                var tmp = nums[m];
                if (tmp > target)
                {
                    r = m - 1;
                    m = (r - l) / 2 + l;
                }
                else if (tmp < target)
                {
                    l = m + 1;
                    m = (r - l) / 2 + l;
                }
                else
                {
                    first = m;
                    while (first - 1 >= 0 && nums[first - 1] == target) first--;
                    last = m;
                    while (last + 1 <= nums.Length - 1 && nums[last + 1] == target) last++;
                    break;
                }
            }

            return new[] { first, last };
        }
    }
}