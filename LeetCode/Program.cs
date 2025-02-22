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
            _83删除排序链表中的重复元素 myLinkedList = new _83删除排序链表中的重复元素();
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);
            myLinkedList.DeleteDuplicates(head);
            Console.ReadKey();
        }
    }
}