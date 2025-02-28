using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _349两个数组的交集 {
        public class Solution {
            public int[] Intersection(int[] nums1, int[] nums2) {
                HashSet<int> hs = new HashSet<int>();
                for (int i = 0; i < nums1.Length; i++)
                {
                    hs.Add(nums1[i]);
                }
                
                HashSet<int> hs2 = new HashSet<int>();

                for (int i = 0; i < nums2.Length; i++)
                {
                    if (hs.Contains(nums2[i]))
                    {
                        hs2.Add(nums2[i]);
                    }
                }

                return hs2.ToArray();
            }
        }
    }
}