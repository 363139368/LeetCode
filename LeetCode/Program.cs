using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        public class TestA
        {
            public int Index;

            public void Func()
            {
                Console.WriteLine(Index);
            }
        }

        private static event EventHandler<TestA> mEvent;

        static void Main(string[] args)
        {
            ListNode list = new ListNode(1)
            {
                next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) {next = new ListNode(5)}}}
            };
            剑指_Offer24反转链表 test = new 剑指_Offer24反转链表();
            list = test.ReverseList(list);
            while (list != null)
            {
                Console.WriteLine(list.val);
                list = list.next;
            }

            Console.ReadKey();

            return;

            //var random = new Random();
            //var randomArray = new int[8];
            //for (int i = 0; i < 8; i++)
            //{
            //    randomArray[i] = random.Next();
            //}

            //Sort sort = new Sort();
            ////sort.HeapSort(randomArray);
            //var temp = new[] {2, 6, 1, 4, 8, 9};
            //sort.MyQuickSort(temp,0,temp.Length-1);
            //foreach (var i in temp)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
        }
    }
}