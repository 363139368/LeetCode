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
            _455分发饼干 test = new _455分发饼干();
            var res = test.FindContentChildren(new[] { 10, 9, 8, 7 }, new[] { 5, 6, 7, 8 });
            Console.WriteLine(res);
            Console.ReadKey();
            //KMP kmp = new KMP();
            //string s = "abcabababc";
            //string t = "abab";
            //kmp.KMPSearch(s.ToCharArray(),t.ToCharArray());
            //Console.WriteLine("end");
            //Console.ReadKey();
        }
    }
}