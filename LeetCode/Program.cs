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
            KMP kmp = new KMP();
            var temp = kmp.GetNextVal("ababcabac".ToArray());

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i] + " " + "ababcabac".Substring(0, i + 1));
            }
            Console.ReadKey();
        }
    }
}