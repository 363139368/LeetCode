using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _49字母异位词分组 {
        public class Solution {
            private int[] char2V = new int[]
            {
                2, 3, 5,
                7, 11, 13,
                17, 19, 23,
                29, 31, 37,
                41, 43, 47,
                53, 59, 61,
                67, 71, 73,
                79, 83, 89,
                97, 101
            };
            
            public IList<IList<string>> GroupAnagrams(string[] strs) {
                
                Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
                for (int i = 0; i < strs.Length; i++)
                {
                    var charArray = strs[i].ToCharArray();
                    Array.Sort(charArray);
                    var key = new string(charArray);
                    if (anagramGroups.TryGetValue(key, out var groups))
                    {
                        groups.Add(strs[i]);
                    }
                    else
                    {
                        List<string> group = new List<string>();
                        group.Add(strs[i]);
                        anagramGroups[key] = group;
                    }
                }
                return new List<IList<string>>(anagramGroups.Values);
            }


        }
    }
}