using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LCR006两数之和II输入有序数组
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while (true)
            {
                var tempSum = numbers[i] + numbers[j];
                if (tempSum == target)
                {
                    return new int[2] {i,j};
                }
                else if (tempSum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
