using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.cn/leetbook/read/illustration-of-algorithm/7fwfti/
    public class LC数组训练1
    {
        public class Solution
        {
            public int[] TrainingPlan(int[] actions)
            {
                for (int i = 1; i < actions.Length; i++) {
                    // j 记录当前数字下标
                    int j = i;
                    // 当前数字比前一个数字小，则将当前数字与前一个数字交换
                    while (j >= 1 && Compare(actions[j], actions[j - 1])) {
                        (actions[j], actions[j - 1]) = (actions[j - 1], actions[j]);
                        // 更新当前数字下标
                        j--;
                    }
                }
                return actions;
            }

            public bool Compare(int a, int b)
            {
                if (a % 2 ==  b % 2 )
                {
                    return a < b;
                }
                else
                {
                    return a % 2 > b % 2;
                }
            }

        }
    }
}
