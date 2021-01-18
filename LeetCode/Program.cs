using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _88合并两个有序数组 test = new _88合并两个有序数组();
            int[] nums1 = new int[] { 4, 5, 6, 0, 0, 0 };
            int[] nums2 = new int[] { 1, 2, 3 };
            test.Merge(nums1, 3, nums2, 3);
            foreach (var i in nums1)
            {
                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}