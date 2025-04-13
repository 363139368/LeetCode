namespace LeetCode
{
    public class _1470重新排列数组
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var res = new int[nums.Length];
            var b = true;
            var m = 0;
            for (var i = 0; i < res.Length; i++)
            {
                if (b)
                {
                    res[i] = nums[m];
                    m++;
                }
                else
                {
                    res[i] = nums[n];
                    n++;
                }

                b = !b;
            }

            return res;
        }
    }
}