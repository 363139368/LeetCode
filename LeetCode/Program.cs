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
            //Console.WriteLine((int)(1 << 16));
            //Console.ReadLine();

            //return;
            //for (int i = 0; i < 128; i++)
            //{
            //    Console.WriteLine(i.ToString() + " : " + (1 << i).ToString());
            //}
            //Console.ReadLine();
            //return;
            _3无重复字符的最长子串 temp = new _3无重复字符的最长子串();
            Console.WriteLine(temp.LengthOfLongestSubstring("bbbbb"));
            Console.ReadLine();

            return;
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
            res |= c;
            Console.WriteLine(res);

            Console.WriteLine((res & b) == b);
            Console.ReadLine();
        }
    }
}
