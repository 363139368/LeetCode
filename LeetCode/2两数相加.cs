using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2两数相加
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode();
            int offset = 0;
            ListNode cur = null;
            ListNode last = null;
            while (l1 != null || l2 != null || offset != 0)
            {
                var v1 = l1 != null ? l1.val : 0;
                var v2 = l2 != null ? l2.val : 0;
                var tmp = v1 + v2 + offset;
                if (tmp >= 10)
                {
                    tmp -= 10;
                    offset = 1;
                }
                else
                {
                    offset = 0;
                }
                if (cur == null)
                {
                    cur = res;
                }
                l1 = l1 != null && l1.next != null ? l1.next : null;
                l2 = l2 != null && l2.next != null ? l2.next : null;
                cur.val = tmp;
                last = cur;
                cur.next = new ListNode();
                cur = cur.next;
            }
            last.next = null;
            return res;
        }
    }
}
