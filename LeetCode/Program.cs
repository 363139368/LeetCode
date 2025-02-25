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
            _566重塑矩阵 tmp = new _566重塑矩阵();
            int[][] param = new int[2][]{new int[]{1,2}, new int[]{3,4}};
            tmp.MatrixReshape(param,1,4);
            
            Console.ReadKey();
        }
    }
}