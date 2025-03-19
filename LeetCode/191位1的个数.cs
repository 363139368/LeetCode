namespace LeetCode
{
    public class _191位1的个数 {
        public class Solution {
            public int HammingWeight1(int n) {
                var res = 0;
                while (n > 0)
                {
                    if ((n & 1) == 1)
                    {
                        res++;
                    }
                    n = n >> 1;
                }
                return res;
            }
            public int HammingWeight(int n) {
                var res = 0;

                while (n > 0)
                {
                    n = n & (n - 1);
                    res++;
                }
                return res;
            }
        }
    }
}