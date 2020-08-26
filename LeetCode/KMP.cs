using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class KMP
    {
        public void KMPSearch(char[] s, char[] t)
        {
            var nextVal = GetNextVal(t);

            int i = 0;    //s
            int j = 0;    //t

            while (i < s.Length && j < t.Length)
            {

            }
        }
        
        public int[] GetNextVal(char[] t)
        {
            var res = new int[t.Length];
            res[0] = -1;
            res[1] = 0;
            int len = 0;
            int i = 1;
            while (i < t.Length - 1)
            {
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
                    len--;
            }
            return res;
        }
    }
}
