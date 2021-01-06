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
            _605种花问题 test = new _605种花问题();
            var res = test.CanPlaceFlowers(new[] { 1, 0, 0, 0, 0, 1 }, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}