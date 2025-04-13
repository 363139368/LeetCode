namespace LeetCode
{
    public class 剑指_Offer24反转链表
    {
        //     1  -  2  -  3  -  4  -  5
        //pre  cur   next
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            var cur = head;
            ListNode pre = null;
            ListNode next = null;

            while (true)
            {
                next = cur.next;

                cur.next = pre;
                if (next == null)
                    return cur;

                pre = cur;
                cur = next;
            }
        }
    }
}