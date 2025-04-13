using System.Collections.Generic;

namespace LeetCode
{
    public class _118杨辉三角
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>(i + 1);
                for (var j = 0; j < i + 1; j++)
                    if (j == 0 || j == i)
                        row.Add(1);
                    else
                        row.Add(list[i - 1][j - 1] + list[i - 1][j]);

                list.Add(row);
            }

            return list;
        }
    }
}