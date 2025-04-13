namespace LeetCode
{
    public class _238除自身以外数组的乘积
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;
            for (var i = 1; i < nums.Length; i++) result[i] = nums[i - 1] * result[i - 1];

            var tmp = 1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                tmp *= nums[i + 1];
                result[i] *= tmp;
            }

            return result;
        }
    }
}