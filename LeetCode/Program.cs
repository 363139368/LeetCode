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
            int a = 1;
            int b = 1 << 1;
            int c = 1 << 2;
            int d = 1 << 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            int res = 0;
            res |= b;
            res |= b;
            res |= c;
            Console.WriteLine(res);

            Console.WriteLine((res & b) == b);
            Console.ReadLine();
        }
    }
}
