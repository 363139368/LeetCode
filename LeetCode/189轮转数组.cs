namespace LeetCode
{
    public class _189轮转数组
    {
        public void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                start++;
                end--;
            }
        }

        public void Rotate(int[] nums, int k)
        {
            if (k == 0) return;
            if (nums.Length <= 1) return;
            if (k == nums.Length) return;
            if (k > nums.Length) k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }
    }
}