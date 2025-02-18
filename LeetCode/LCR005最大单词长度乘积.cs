using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LCR005最大单词长度乘积
    {
        public int MaxProduct(string[] words)
        {
            int res = 0;

            for (int i = 0; i < words.Length; i++)
            {
                var iStrLength = words[i].Length;
                var iStrBit = String2BitInt(words[i]);
                for(int j = i+1; j < words.Length; j++)
                {
                    var jStrLength = words[j].Length;
                    var curRes = iStrLength * jStrLength;
                    if (curRes < res)
                        continue;
                    var jStrbit = String2BitInt(words[j]);
                    if ((iStrBit & jStrbit) == 0)
                    {
                        res = curRes;
                    }
                }
            }
            return res;
        }

        public int String2BitInt(string str)
        {
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var tmp = 1 << Char2Int(str[i]);
                res |= tmp;
            }
            return res;
        }

        public int Char2Int(char c)
        {
            return (int)(c) - (int)('a');
        }
    }
}
