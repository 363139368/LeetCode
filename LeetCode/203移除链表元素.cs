namespace LeetCode
{
    public class _203移除链表元素
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            while (head != null && head.val == val) head = head.next;

            if (head == null)
                return null;

            ListNode pre = null;
            var cur = head;
            while (cur != null)
                if (cur.val == val)
                {
                    if (pre != null) pre.next = cur.next;
                    cur = cur.next;
                }
                else
                {
                    pre = cur;
                    cur = cur.next;
                }

            return head;
        }
    }
}