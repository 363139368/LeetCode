using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _84柱状图中最大的矩形
    {
        public int LargestRectangleArea(int[] heights)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            HashSet<int> ignore = new HashSet<int>();
            int minValue = 0;
            int max = 0;
            for (int i = 0, weight = 0; i < heights.Length; i++)
            {
                var cur = heights[i];
                if (ignore.Contains(cur))
                    continue;
                weight++;
                if (dic.TryGetValue(cur, out var count))
                    dic[cur] = count + 1;
                else
                    dic[cur] = 1;

                var itor = dic.GetEnumerator();
                while (itor.MoveNext())
                {

                }
            }
            return 0;
        }
    }
}
