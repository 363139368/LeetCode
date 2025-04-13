namespace LeetCode
{
    public class LCR005最大单词长度乘积
    {
        public int MaxProduct(string[] words)
        {
            var res = 0;

            for (var i = 0; i < words.Length; i++)
            {
                var iStrLength = words[i].Length;
                var iStrBit = String2BitInt(words[i]);
                for (var j = i + 1; j < words.Length; j++)
                {
                    var jStrLength = words[j].Length;
                    var curRes = iStrLength * jStrLength;
                    if (curRes < res)
                        continue;
                    var jStrbit = String2BitInt(words[j]);
                    if ((iStrBit & jStrbit) == 0) res = curRes;
                }
            }

            return res;
        }

        public int String2BitInt(string str)
        {
            var res = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var tmp = 1 << Char2Int(str[i]);
                res |= tmp;
            }

            return res;
        }

        public int Char2Int(char c)
        {
            return c - 'a';
        }
    }
}