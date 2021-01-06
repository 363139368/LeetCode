using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _605种花问题
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n <= 0)
                return true;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                    continue;
                if (i - 1 >= 0 && flowerbed[i - 1] == 1)
                    continue;
                if (i + 1 < flowerbed.Length && flowerbed[i + 1] == 1)
                    continue;
                flowerbed[i] = 1;
                n--;
                if (n <= 0)
                    return true;
            }
            return false;
        }
    }
}
