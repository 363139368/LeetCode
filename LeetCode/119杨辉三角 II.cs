using System.Collections.Generic;

namespace LeetCode
{
    public class _119杨辉三角_II
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> list = new List<IList<int>>();
            for (var i = 0; i < rowIndex + 1; i++)
            {
                var row = new List<int>(i + 1);
                for (var j = 0; j < i + 1; j++)
                    if (j == 0 || j == i)
                        row.Add(1);
                    else
                        row.Add(list[i - 1][j - 1] + list[i - 1][j]);

                if (i == rowIndex - 1)
                    return row;
                list.Add(row);
            }

            return null;
        }
    }
}