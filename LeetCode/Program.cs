using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {


        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1,2);
            myLinkedList.Get(1);
            myLinkedList.DeleteAtIndex(1);
            myLinkedList.Get(1);
            Console.ReadKey();
        }
    }
}