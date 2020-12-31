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
            _135分发糖果 test = new _135分发糖果();
            var res = test.Candy(new[] { 1, 2, 87, 87, 87, 2, 1 });
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}