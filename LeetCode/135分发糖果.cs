using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _135分发糖果
    {
        public int Candy(int[] ratings)
        {
            int[] candys = new int[ratings.Length];
            for (int i = 0; i < candys.Length; i++)
            {
                candys[i] = 1;
            }
            for (int i = 1; i < candys.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    candys[i] = candys[i - 1] + 1;
            }
            for (int i = candys.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1] && candys[i] <= candys[i + 1])
                    candys[i] = candys[i + 1] + 1;
            }

            return candys.Sum();
        }
    }
}
