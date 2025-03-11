using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LC训练计划_合并两个有序单链表.Solution tmp = new LC训练计划_合并两个有序单链表.Solution();
            var tmp1 = tmp.TrainningPlan(new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4))));
        }
    }
}