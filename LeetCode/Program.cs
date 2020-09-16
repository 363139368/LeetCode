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
            string s = "abcabababc";
            string t = "abab";
            kmp.KMPSearch(s.ToCharArray(),t.ToCharArray());
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}