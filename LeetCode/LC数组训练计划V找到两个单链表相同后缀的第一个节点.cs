namespace LeetCode
{
    //https://leetcode.cn/leetbook/read/illustration-of-algorithm/7fvoq2/
    public class LC数组训练计划V找到两个单链表相同后缀的第一个节点
    {
        public class Solution
        {
            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                ListNode A = headA, B = headB;
                while (A != B)
                {
                    A = A != null ? A.next : headB;
                    B = B != null ? B.next : headA;
                }

                return A;
            }
        }
    }
}