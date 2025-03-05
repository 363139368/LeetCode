using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _290单词规律
    {
        public class Solution
        {
            public bool WordPattern(string pattern, string s)
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();
                var arr = s.Split(' ');
                int tmp = 1;
                int[] ints = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!dic.ContainsKey(arr[i]))
                    {
                        dic[arr[i]] = tmp;
                        tmp++;
                    }

                    ints[i] = dic[arr[i]];
                }
                if (pattern.Length != ints.Length) return false;

                Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
                tmp = 1;
                for (int i = 0; i < pattern.Length; i++)
                {
                    var cur = pattern[i];
                    if (!keyValuePairs.ContainsKey(cur))
                    {
                        keyValuePairs[cur] = tmp;
                        if (ints[i] != tmp)
                        {
                            return false;
                        }
                        tmp++;
                    }
                    else
                    {
                        if (ints[i] != keyValuePairs[cur])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
