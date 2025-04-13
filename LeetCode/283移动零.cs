namespace LeetCode
{
    public class _283移动零
    {
        public void MoveZeroes(int[] nums)
        {
            var offset = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    offset++;
                    continue;
                }

                if (offset > 0) nums[i - offset] = nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
                if (offset > 0 && i + offset + 1 > nums.Length)
                    nums[i] = 0;
        }
    }
}