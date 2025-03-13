namespace LeetCode
{
    //https://leetcode.cn/leetbook/read/illustration-of-algorithm/7fnm66/
    public class LC训练计划_合并两个有序单链表
    {
        public class Solution {
            public ListNode TrainningPlan(ListNode l1, ListNode l2) {
                ListNode head = new ListNode(0);
                var cur = head;
                var l1C = l1;
                var l2C = l2;
                while (true)
                {
                    if (l1C == null && l2C == null)
                    {
                        break;
                    }
                    if (l1C == null)
                    {
                        cur.next = l2C;
                        cur = cur.next;
                        l2C = l2C.next;
                    }
                    else if (l2C == null)
                    {
                        cur.next = l1C;
                        cur = cur.next;
                        l1C = cur.next;
                    }
                    else
                    {
                        if (l1C.val <= l2C.val)
                        {
                            cur.next = l1C;
                            cur = cur.next;
                            l1C = l1C.next;
                        }
                        else
                        {
                            cur.next = l2C;
                            cur = cur.next;
                            l2C = l2C.next;
                        }
                    }
                }
                return head.next;
            }
        }
    }
}