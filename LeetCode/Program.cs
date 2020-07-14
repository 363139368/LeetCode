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
            {
                _4寻找两个正序数组的中位数 _4 = new _4寻找两个正序数组的中位数();
                var temp = _4.FindMedianSortedArrays(new int[] { 4 }, new int[] { 1,2,3 });
                Console.WriteLine(temp);
                Console.ReadLine();
                return;
            }
            {
                _3无重复字符的最长子串 _3 = new _3无重复字符的最长子串();
                Console.WriteLine(_3.LengthOfLongestSubstring("bbbbb"));
                Console.ReadLine();
                return;
            }
        }
    }
}
