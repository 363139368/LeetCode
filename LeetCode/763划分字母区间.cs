using System.Collections.Generic;

namespace LeetCode
{
    public class _763划分字母区间
    {
        public IList<int> PartitionLabels(string S)
        {
            if (S.Length == 1)
                return new List<int> { 1 };

            IList<int> res = new List<int>();
            var dic = new Dictionary<char, Info>();
            for (var i = 0; i < S.Length; i++)
            {
                var cur = S[i];
                if (!dic.TryGetValue(cur, out var info))
                {
                    info = new Info { Char = cur, StartIndex = i };
                    dic.Add(cur, info);
                }

                info.Count++;
                info.EndIndex = i;
            }

            var startIndex = 0;
            var endIndex = dic[S[0]].EndIndex;


            var index = 0;
            while (index < S.Length)
            {
                if (index == endIndex)
                {
                    res.Add(index - startIndex + 1);
                    index = endIndex + 1;
                    startIndex = endIndex + 1;
                    if (startIndex >= S.Length)
                        break;
                    endIndex = dic[S[startIndex]].EndIndex;
                    continue;
                }

                if (index == startIndex)
                {
                    index++;
                    continue;
                }

                var info = dic[S[index]];
                if (info.EndIndex <= endIndex)
                {
                    index++;
                    continue;
                }

                endIndex = info.EndIndex;
                index++;
            }

            return res;
        }

        public class Info
        {
            public char Char;
            public int Count;
            public int EndIndex;
            public int StartIndex;
        }
    }
}