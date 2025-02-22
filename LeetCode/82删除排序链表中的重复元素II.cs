namespace LeetCode
{
    public class _82删除排序链表中的重复元素II {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode pre = null;
            var current = head;
            while (current != null)
            {
                DeleteDuplicatesForHead(current,out var isClear);
                if (isClear)
                {
                    if (pre != null)
                    {
                        pre.next = current.next;
                    }
                    else
                    {
                        if (current.next == null)
                            return null;
                        else
                        {
                            pre = current.next;
                            head = pre;
                        }
                    }
                }
                pre = current;
                current = current.next;
            }
            return head;
        }

        public void DeleteDuplicatesForHead(ListNode head,out bool IsClear)
        {
            IsClear = false;
            var pre = head;
            var current = head.next;
            var curVal = current.val;
            while (current != null)
            {
                if (curVal == current.val)
                {
                    IsClear = true;
                    pre.next = current.next;
                    current = current.next;
                }
                else
                {
                    return;
                }
            }
            
        }
    }
}