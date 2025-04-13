namespace LeetCode
{
    public class _303区域和检索数组不可变
    {
        public class NumArray
        {
            private readonly int[] m_preSum;

            public NumArray(int[] nums)
            {
                m_preSum = new int[nums.Length + 1];
                m_preSum[0] = 0;
                for (var i = 0; i < nums.Length; i++) m_preSum[i + 1] = nums[i] + m_preSum[i];
            }

            public int SumRange(int left, int right)
            {
                return m_preSum[right + 1] - m_preSum[left];
            }
        }
    }
}