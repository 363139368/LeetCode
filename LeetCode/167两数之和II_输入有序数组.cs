namespace LeetCode
{
    public class _167两数之和II_输入有序数组
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;

            while (true)
            {
                var leftValue = numbers[i];
                var rightValue = numbers[j];
                var curSum = leftValue + rightValue;
                if (curSum == target)
                    break;
                if (curSum > target)
                    j--;
                else
                    i++;
            }

            return new[] { i + 1, j + 1 };
        }
    }
}