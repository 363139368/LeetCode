using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _203移除链表元素
    {

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            while (true)
            {
                if (head != null && head.val != val)
                {
                    break;
                }
                if (head.val == val)
                {
                    head = head.next;
                }
                if (head == null)
                {
                    return null;
                }
            }

            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                if (cur.val == val)
                {
                    if (pre != null)
                    {
                        pre.next = cur.next;
                    }
                }
                else
                {
                    pre = cur;
                    cur = cur.next;
                }

            }
            return head;
        }
    }
}
