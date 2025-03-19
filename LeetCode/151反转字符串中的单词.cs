using System;

namespace LeetCode
{
    public class _151反转字符串中的单词 {
        public class Solution {
            public string ReverseWords(string s)
            {
                while (s.Contains("  "))
                {
                    s = s.Replace("  ", " ");
                }

                var res = s.Trim().ToCharArray();
                ReverseArray(res, 0, res.Length - 1);
                int lastEmpty = -1;
                for (int i = 0; i < res.Length; i++)
                {
                    if (res[i] == ' ')
                    {
                        ReverseArray(res, lastEmpty + 1,i-1);
                        lastEmpty = i;
                    }
                }
                if (lastEmpty != res.Length - 1)
                {
                    ReverseArray(res, lastEmpty + 1,res.Length - 1);
                }
                return new string(res).Trim();
            }

            public void ReverseArray(char[] arr, int start, int end)
            {
                while (start < end)
                {
                    (arr[start], arr[end]) = (arr[end], arr[start]);
                    start++;
                    end--;
                }
            }
        }
    }
}