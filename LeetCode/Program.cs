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
            _406根据身高重建队列 test = new _406根据身高重建队列();
            var res = test.ReconstructQueue(new int[][]
            {
                new int[] {7, 0}, new int[] {4, 4}, new int[] {7, 1}, new int[] {5, 0}, new int[] {6, 1},
                new int[] {5, 2}
            });
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}