namespace LeetCode
{
    //https://leetcode.cn/leetbook/read/illustration-of-algorithm/7fmls1/
    public class _删除链表节点
    {
        public class Solution {
            public ListNode DeleteNode(ListNode head, int val) {
                if(head == null)
                    return head;
                var tmp = new ListNode(0);
                tmp.next = head;
                var cur = tmp;
                while (cur != null)
                {
                    if (cur.next != null && cur.next.val == val)
                    {
                        cur.next = cur.next.next;
                    }
                    cur = cur.next;
                }
                return tmp.next;
            }
        }
    }
}