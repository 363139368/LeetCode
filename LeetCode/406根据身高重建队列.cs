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
            int count = list.Count;
            for (int i = 1; i < count; i++)
            {
                int secondCount = list[i][1];
                int tarIndex = 0;
                for (int ii = 0; ii < count; ii++)
                {
                    if (list[ii][0] >= list[i][0])
                        secondCount--;
                    if (secondCount < 0)
                    {
                        tarIndex = ii;
                        break;
                    }
                }
                if(tarIndex == i)
                    continue;
                var temp = list[i];
                list.RemoveAt(i);
                list.Insert(tarIndex,temp);
            }
            people = list.ToArray();
            return people;
        }
        public static int Compare(int [] a1, int[] a2)
        {
            var res = a2[0].CompareTo(a1[0]);
            if(res == 0)
                res = a1[1].CompareTo(a2[1]);
            return res;
        }
    }
}
