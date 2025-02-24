using System.Collections.Generic;

namespace LeetCode
{
    public class _82删除排序链表中的重复元素II {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var fakeHead = new ListNode();
            fakeHead.val = 101;
            fakeHead.next = head;
            var cur = fakeHead;
            while (cur != null)
            {
                if (cur.next == null ||cur.next.next == null)
                    break;
                if (cur.next.val == cur.next.next.val)
                {
                    var tmp = cur.next.next;
                    while (tmp.next != null && tmp.val == tmp.next.val)
                    {
                        tmp.next = tmp.next.next;
                    }

                    cur.next = cur.next.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return fakeHead.next;
        }
    }
}