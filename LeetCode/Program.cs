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
            _665非递减数列 test = new _665非递减数列();
            var res = test.CheckPossibility(new []{-1,4,2,3});
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}