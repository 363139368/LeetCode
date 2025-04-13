namespace LeetCode
{
    public class _4寻找两个正序数组的中位数
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var lastNum = int.MinValue;
            var cur = int.MinValue;
            var sum = (nums1 != null ? nums1.Length : 0) + (nums2 != null ? nums2.Length : 0);
            var isOddNum = sum % 2 != 0;
            var tarIndex = isOddNum ? (sum - 1) / 2 : sum / 2;
            var index1 = 0;
            var index2 = 0;
            var curIndex = 0;
            while (true)
            {
                if (nums1 == null || index1 >= nums1.Length)
                {
                    lastNum = cur;
                    cur = nums2[index2];
                    index2++;
                }
                else if (nums2 == null || index2 >= nums2.Length)
                {
                    lastNum = cur;
                    cur = nums1[index1];
                    index1++;
                }
                else
                {
                    lastNum = cur;
                    if (nums1[index1] < nums2[index2])
                    {
                        cur = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        cur = nums2[index2];
                        index2++;
                    }
                }

                if (curIndex == tarIndex)
                {
                    if (isOddNum)
                        return cur;
                    return lastNum + (cur - lastNum) / 2.0f;
                }

                curIndex++;
            }
        }
    }
}