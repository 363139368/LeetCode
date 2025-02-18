using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LCR004只出现一次的数字II
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int,bool> dic = new Dictionary<int,bool>(nums.Length /3);
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.TryGetValue(nums[i], out var b))
                {
                    if (b)
                    {
                        dic[nums[i]] = false;
                    }
                    else
                    {
                        dic.Remove(nums[i]);
                    }
                }
                else
                {
                    dic[nums[i]] = true;
                }

            }
            var ator = dic.GetEnumerator();
            while (ator.MoveNext())
            {
                return ator.Current.Key;
            }
            return 0;
        }

        public int BitSingleNumber(int[] nums)
        {
            int[] res = new int[32];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if ((nums[i] >> j & 1) > 0)
                    {
                        res[j]++;
                    }
                }
            }

            int ant = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] > 0 && res[i] % 3 > 0)
                {
                    ant += 1 << i;
                }
            }
            return ant;
        }
    }
}
