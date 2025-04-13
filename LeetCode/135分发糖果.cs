using System.Linq;

namespace LeetCode
{
    internal class _135分发糖果
    {
        public int Candy(int[] ratings)
        {
            var candys = new int[ratings.Length];
            for (var i = 0; i < candys.Length; i++) candys[i] = 1;
            for (var i = 1; i < candys.Length; i++)
                if (ratings[i] > ratings[i - 1])
                    candys[i] = candys[i - 1] + 1;
            for (var i = candys.Length - 2; i >= 0; i--)
                if (ratings[i] > ratings[i + 1] && candys[i] <= candys[i + 1])
                    candys[i] = candys[i + 1] + 1;

            return candys.Sum();
        }
    }
}