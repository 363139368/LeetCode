using System.Collections.Generic;

namespace LeetCode
{
    public class _138随机链表的复制
    {
        public class Solution
        {
            public Node CopyRandomList(Node head)
            {
                if (head == null) return null;
                var temp = new Dictionary<Node, Node>();
                var res = new Node(head.val);

                temp[head] = res;

                var lastRes = res;
                var cur = head.next;
                while (cur != null)
                {
                    lastRes.next = new Node(cur.val);
                    temp.Add(cur, lastRes.next);
                    cur = cur.next;
                    lastRes = lastRes.next;
                }

                cur = head;
                var resCur = temp[head];
                while (resCur != null)
                {
                    if (cur.random != null) resCur.random = temp[cur.random];
                    cur = cur.next;
                    resCur = resCur.next;
                }

                return res;
            }

            public class Node
            {
                public Node next;
                public Node random;
                public int val;

                public Node(int _val)
                {
                    val = _val;
                    next = null;
                    random = null;
                }
            }
        }
    }
}