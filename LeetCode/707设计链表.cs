using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyLinkedList
    {
        public LinkNode FirstNode;
        public LinkNode LastNode;
        public int Count = 0;
        public class LinkNode
        {
            public int val;
            public LinkNode next;
            public LinkNode pre;
        }
        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            if (index == Count - 1)
            {
                return LastNode.val;
            }
            var tar = FindNode(index);
            if (tar == null)
            {
                return -1;
            }
            else
            {
                return tar.val;
            }
        }

        public void AddAtHead(int val)
        {
            var node = new LinkNode() { val = val};
            if (FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
            }
            else
            {
                node.next = FirstNode;
                FirstNode.pre = node;
                FirstNode = node;
            }
            Count++;
        }

        public void AddAtTail(int val)
        {
            var node = new LinkNode() { val = val};
            if(LastNode == null)
            {
                LastNode = node;
                FirstNode = node;
            }
            else
            {
                LastNode.next = node;
                node.pre = LastNode;
                LastNode = node;
            }

            Count++;
        }

        private LinkNode FindNode(int index)
        {
            if (FirstNode == null || LastNode == null)
            {
                return null;
            }
            if (Count == 0)
            {
                return null;
            }
            if (index == Count - 1)
            {
                return LastNode;
            }
            if (index == 0)
            {
                return FirstNode;
            }
            if (index < Count)
            {
                int i = 0;
                LinkNode node = FirstNode;
                while (i != index)
                {
                    node = node.next;
                    i++;
                }
                return node;
            }
            return null;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > Count)
            {
                return;
            }

            if (index == Count)
            {
                AddAtTail(val);
            }
            else if (index == 0)
            {
                AddAtHead(val);
            }
            else
            {
                LinkNode tar = null;
                if (index == Count - 1)
                {
                    tar = LastNode;
                }
                else
                {
                    tar = FindNode(index);
                }
                if (tar == null)
                {
                    return;
                }
                var node = new LinkNode();
                node.val = val;
                node.pre = tar.pre;
                node.next = tar;
                if (node.pre != null)
                {
                    node.pre.next = node;
                }
                tar.pre = node;
                Count++;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index >= Count)
            {
                return;
            }

            if (index == 0)
            {
                if (Count == 1)
                {
                    FirstNode = null;
                    LastNode = null;
                }
                else
                {
                    FirstNode = FirstNode.next;
                }
            }
            else if (index == Count - 1)
            {
                if (Count == 1)
                {
                    FirstNode = null;
                    LastNode = null;
                }
                else
                {
                    LastNode = LastNode.pre;
                }
            }
            else
            {
                var tar = FindNode(index);
                if (tar == null)
                {
                    return;
                }
                if (tar.pre != null)
                {
                    tar.pre.next =tar.next;
                }
                if (tar.next != null)
                {
                    tar.next.pre = tar.pre;
                }
            }
            Count--;
        }
    }
}
