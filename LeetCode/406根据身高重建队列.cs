using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _406根据身高重建队列
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            if (people.Length == 1)
                return people;
            Array.Sort(people, Compare);
            var list = people.ToList();
            int i = 0, count = list.Count;
            while (i<count)
            {
                
            }
            return people;
        }
        public static int Compare(int [] a1, int[] a2)
        {
            var res = a1[0].CompareTo(a2[0]);
            if(res == 0)
                res = a1[1].CompareTo(a2[1]);
            return res;
        }
    }
}
