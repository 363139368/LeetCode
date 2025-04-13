namespace LeetCode
{
    //https://leetcode.cn/leetbook/read/illustration-of-algorithm/7f2ng5/
    public class LC训练计划_单链表倒数第N个数
    {
        public class Solution
        {
            public ListNode TrainingPlan(ListNode head, int cnt)
            {
                var tmp1 = head;
                var tmp2 = head;
                for (var i = 0; i < cnt; i++) tmp1 = tmp1.next;

                while (tmp1 != null)
                {
                    tmp2 = tmp2.next;
                    tmp1 = tmp1.next;
                }

                return tmp2;
            }
        }
    }
}