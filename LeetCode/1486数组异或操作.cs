namespace LeetCode
{
    public class _1486数组异或操作
    {
        public int XorOperation(int n, int start)
        {
            var nums = new int[n];
            nums[0] = start;
            var res = start;
            for (var i = 1; i < nums.Length; i++)
            {
                var cur = start + 2 * i;
                nums[i] = cur;
                res ^= cur;
            }

            return res;
        }
    }
}