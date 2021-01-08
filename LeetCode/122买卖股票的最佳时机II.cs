using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _122买卖股票的最佳时机II
    {
        public int MaxProfit(int[] prices)
        {
            int res = 0;
            if (prices.Length <= 1)
                return res;
            int inPrice = prices[0];
            int outPrice = 0;
            int i = 0;
            while (i < prices.Length)
            {
                var cur = prices[i];
                if (cur > inPrice && cur > outPrice)
                    outPrice = cur;
                if (cur < outPrice)
                {
                    res += (outPrice - inPrice);
                    inPrice = cur;
                    outPrice = 0;
                    i++;
                    continue;
                }

                if (cur < inPrice)
                {
                    inPrice = cur;
                    i++;
                    continue;
                }

                i++;
            }

            if (outPrice > inPrice)
                res += (outPrice - inPrice);

            return res;
        }
    }
}
