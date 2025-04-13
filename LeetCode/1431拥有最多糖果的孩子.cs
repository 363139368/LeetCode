using System.Collections.Generic;

namespace LeetCode
{
    public class _1431拥有最多糖果的孩子
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> res = new List<bool>(candies.Length);
            var max = 0;
            for (var i = 0; i < candies.Length; i++)
                if (candies[i] > max)
                    max = candies[i];
            for (var i = 0; i < candies.Length; i++) res.Add(candies[i] + extraCandies >= max);
            return res;
        }
    }
}