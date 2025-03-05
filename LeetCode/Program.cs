using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            // 使用随机数对数组进行乱序
            Random rand = new Random();
            for (int i = nums.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            
            Sort.Show(nums);
            Array.Sort(nums);
            Sort.Show(nums);

            // Sort.Show(nums);
            // Sort sort = new Sort();
            // sort.MyQuickSort(nums);
            Console.ReadKey();
        }
    }
}