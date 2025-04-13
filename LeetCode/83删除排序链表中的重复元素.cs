namespace LeetCode
{
    public class _83删除排序链表中的重复元素
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            var pre = head;
            var current = head.next;
            var curVal = head.val;
            while (current != null)
                if (current.val == curVal)
                {
                    pre.next = current.next;
                    current = current.next;
                }
                else
                {
                    curVal = current.val;
                    pre = current;
                    current = current.next;
                }

            return head;
        }
    }
}