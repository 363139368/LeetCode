namespace LeetCode
{
    public class _1480一维数组的动态和
    {
        public int[] RunningSum(int[] nums)
        {
            var res = new int[nums.Length];
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                res[i] = sum;
            }

            return res;
        }
    }
}