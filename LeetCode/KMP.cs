using System;

namespace LeetCode
{
    public class KMP
    {
        public void KMPSearch(char[] s, char[] t)
        {
            var nextVal = GetNextVal(t);

            var i = 0; //s
            var j = 0; //t

            while (i < s.Length || j < t.Length)
            {
                if (i >= s.Length) return;

                if (j >= t.Length)
                {
                    Console.WriteLine($"{i} finded!");
                    j = nextVal[j - 1] + 1;
                    continue;
                }

                if (j == -1)
                {
                    i++;
                    j++;
                    continue;
                }

                if (s[i] == t[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = nextVal[j];
                }
            }
        }

        public int[] GetNextVal(char[] t)
        {
            var res = new int[t.Length];
            res[0] = -1;
            res[1] = 0;
            var len = 0;
            var i = 1;
            while (i < t.Length - 1)
                if (t[i] == t[len])
                {
                    len++;
                    res[i + 1] = len;
                    i++;
                }
                else if (len == 0)
                {
                    res[i + 1] = 0;
                    i++;
                }
                else
                {
                    len--;
                }

            return res;
        }
    }
}