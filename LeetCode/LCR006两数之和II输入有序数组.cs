namespace LeetCode
{
    public class LCR006两数之和II输入有序数组
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var i = 0;
            var j = numbers.Length - 1;
            while (true)
            {
                var tempSum = numbers[i] + numbers[j];
                if (tempSum == target) return new int[2] { i, j };

                if (tempSum > target)
                    j--;
                else
                    i++;
            }
        }
    }
}