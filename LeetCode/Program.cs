using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomArray = new int[8];
            for (int i = 0; i < 8; i++)
            {
                randomArray[i] = random.Next();
            }

            Sort sort = new Sort();
            //sort.HeapSort(randomArray);
            var temp = new[] {2, 6, 1, 4, 8, 9};
            sort.MyQuickSort(temp,0,temp.Length-1);
            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}