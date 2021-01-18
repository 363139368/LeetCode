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
            _167两数之和II_输入有序数组 test = new _167两数之和II_输入有序数组();
            var res = test.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            foreach (var i in res)
            {
                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}