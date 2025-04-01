using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class _232用栈实现队列 {
        public class MyQueue {

            private Stack<int> stack = new Stack<int>();
            private Stack<int> stack1 = new Stack<int>();
            
            public MyQueue() {
        
            }
    
            public void Push(int x) {
                stack.Push(x);
            }
    
            public int Pop() {
                if (stack1.Count > 0)
                {
                    return stack1.Pop();
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        stack1.Push(stack.Pop());
                    }
                    return stack1.Pop();
                }
            }
    
            public int Peek() {
                if (stack1.Count > 0)
                {
                    return stack1.Peek();
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        stack1.Push(stack.Pop());
                    }
                    return stack1.Peek();
                }
            }
    
            public bool Empty() {
                if (stack.Count == 0 && stack1.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}