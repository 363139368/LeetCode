using System.Collections.Generic;

namespace LeetCode
{
    public class LCR004只出现一次的数字II
    {
        public int SingleNumber(int[] nums)
        {
            var dic = new Dictionary<int, bool>(nums.Length / 3);
            for (var i = 0; i < nums.Length; i++)
                if (dic.TryGetValue(nums[i], out var b))
                {
                    if (b)
                        dic[nums[i]] = false;
                    else
                        dic.Remove(nums[i]);
                }
                else
                {
                    dic[nums[i]] = true;
                }

            var ator = dic.GetEnumerator();
            while (ator.MoveNext()) return ator.Current.Key;
            return 0;
        }

        public int BitSingleNumber(int[] nums)
        {
            var res = new int[32];

            for (var i = 0; i < nums.Length; i++)
            for (var j = 0; j < 32; j++)
                if (((nums[i] >> j) & 1) > 0)
                    res[j]++;

            var ant = 0;
            for (var i = 0; i < res.Length; i++)
                if (res[i] > 0 && res[i] % 3 > 0)
                    ant += 1 << i;

            return ant;
        }
    }
}