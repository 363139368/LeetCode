namespace LeetCode
{
    public class LCR_003_比特位计数
    {
        public int[] CountBits(int n)
        {
            var ints = new int[n + 1];
            for (var i = 0; i <= n; i++)
            {
                var tar = i >> 1;
                var offset = i & 1;
                var tmp = ints[tar];
                ints[i] = tmp + offset;
            }

            return ints;
        }
    }
}