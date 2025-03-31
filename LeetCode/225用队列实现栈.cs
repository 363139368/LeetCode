using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class _225用队列实现栈 {
        

        
        public class MyStack {

            private Queue<int> queue = new Queue<int>();
            public MyStack() {
        
            }
    
            public void Push(int x)
            {
                var c = queue.Count;
                queue.Enqueue(x);
                for (int i = 0; i < c; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
    
            public int Pop() {
                if(queue.Count == 0)
                    return -1;
                return queue.Dequeue();
            }
    
            public int Top() {
                if(queue.Count == 0)
                    return -1;
                return queue.Peek();
            }
    
            public bool Empty() {
                return queue.Count == 0;
            }
        }
    }
}