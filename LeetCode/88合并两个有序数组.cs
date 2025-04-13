namespace LeetCode
{
    public class _88合并两个有序数组
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;
            var i = nums1.Length - 1;
            var b = true;
            while (m >= 0 || n >= 0)
            {
                if (n < 0)
                    b = true;
                else if (m < 0)
                    b = false;
                else
                    b = nums1[m] >= nums2[n];

                if (b)
                {
                    nums1[i] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[i] = nums2[n];
                    n--;
                }

                i--;
            }
        }
    }
}