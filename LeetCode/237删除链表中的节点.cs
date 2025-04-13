namespace LeetCode
{
    public class _237删除链表中的节点
    {
        public void DeleteNode(ListNode node)
        {
            ListNode pre = null;
            var cur = node;
            while (cur != null && cur.next != null)
            {
                cur.val = cur.next.val;
                pre = cur;
                cur = cur.next;
            }

            if (pre != null)
                pre.next = null;
        }
    }
}