using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1431拥有最多糖果的孩子
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> res = new List<bool>(candies.Length);
            int max = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                    max = candies[i];
            }
            for (int i = 0; i < candies.Length; i++)
            {
                res.Add(candies[i] + extraCandies >= max);
            }
            return res;
        }
    }
}
