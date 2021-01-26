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
            _680验证回文字符串Ⅱ test = new _680验证回文字符串Ⅱ();
            var res = test.ValidPalindrome("ebcbbececabbacecbbcbe");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}