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
            _189轮转数组 tmp = new _189轮转数组();
            var res = new int[] { 1, 2};
            tmp.Rotate(res,3);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(i.ToString() + res[i].ToString());
            }
            Console.Read();
        }
    }
}