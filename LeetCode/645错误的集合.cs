namespace LeetCode
{
    public class _645错误的集合 {
        public int[] FindErrorNums(int[] nums) {
            int[] bucket = new int[nums.Length];
            var res = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i] - 1;
                bucket[cur]++;
                if (bucket[cur] > 1)
                {
                    res[0] = nums[i];
                }
            }

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] == 0)
                {
                    res[1] = i + 1;
                    return res;
                }
            }
            return res;
        }
    }
}