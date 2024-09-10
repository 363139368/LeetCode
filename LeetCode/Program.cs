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
            BitCalculator tmp = new BitCalculator();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var res = tmp.Add(i, j);
                    Console.WriteLine($"{i} + {j} = {res}, IsOk:{res == i + j}");
                }
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var res = tmp.Subtract(i, j);
                    Console.WriteLine($"{i} - {j} = {res}, IsOk:{res == i - j}");
                }
            }

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var res = tmp.Multiply(i, j);
                    Console.WriteLine($"{i} * {j} = {res}, IsOk:{res == i * j}");
                }
            }
            Console.ReadKey();
        }
    }
}