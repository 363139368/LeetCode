using System.Collections.Generic;

namespace LeetCode
{
    public class _19删除链表的倒数第_N_个结点
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var q = new Queue<ListNode>(n + 1);
            var cur = head;
            var listCount = 0;
            while (cur != null)
            {
                if (q.Count == n + 1)
                    q.Dequeue();
                q.Enqueue(cur);
                cur = cur.next;
                listCount++;
            }

            if (listCount == n)
                return head.next;
            if (q.Count == 0)
                return null;
            var tarPre = q.Dequeue();
            if (tarPre == null)
                return null;
            if (q.Count == 0)
                return null;
            var tar = q.Dequeue();
            if (tar == null)
                return null;
            tarPre.next = tar.next;
            if (tar == head)
                return head.next;
            return head;
        }
    }
}