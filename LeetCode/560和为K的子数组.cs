using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _560和为K的子数组
    {
        public int SubarraySum(int[] nums, int k)
        {
            // key: 前缀和
            // value: 该前缀和出现的次数
            Dictionary<int, int> pre = new Dictionary<int, int>();

            // 初始化
            // 前缀和为0在数组开始前出现过1次
            // 这样才能统计从下标0开始的子数组
            pre[0] = 1;

            // 当前前缀和
            int sum = 0;

            // 满足条件的子数组个数
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // 更新当前位置的前缀和
                sum += nums[i];

                /*
                 *
                 * 前缀和核心公式：
                 *
                 * sums[right] - sums[left] = k
                 *
                 * 移项得到：
                 *
                 * sums[left] = sums[right] - k
                 *
                 * 当前：
                 * sums[right] = sum
                 *
                 * 所以需要查找：
                 *
                 * sum - k
                 *
                 */
                int need = sum - k;

                /*
                 * 如果之前出现过 need
                 *
                 * 说明存在一个或多个 left
                 *
                 * 满足：
                 *
                 * sum - need = k
                 *
                 * 即形成和为 k 的子数组
                 *
                 * 注意：
                 * pre[need] 记录的是出现次数
                 * 所以一次可能增加多个答案
                 *
                 */
                if (pre.ContainsKey(need))
                {
                    res += pre[need];
                }

                /*
                 * 将当前前缀和加入哈希表
                 *
                 * 供后面的元素作为 left 使用
                 *
                 */
                if (pre.ContainsKey(sum))
                {
                    pre[sum]++;
                }
                else
                {
                    pre[sum] = 1;
                }
            }

            return res;
        }
    }
}
