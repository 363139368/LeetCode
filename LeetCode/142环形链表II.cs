﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        
        public int HashValue;
        public ListNode(int x)
        {
            val = x;
            next = null;
            HashValue = GetHashCode();
        }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
            HashValue = GetHashCode();
        }
    }

    public class _142环形链表II
    {

        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            do
            {
                if (fast == null || fast.next == null)
                    return null;
                fast = fast.next.next;
                slow = slow.next;
            } while (slow != fast);
            fast = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return fast;
        }
    }
}
