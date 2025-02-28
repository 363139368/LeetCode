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
            _706设计哈希映射.MyHashMap myHashMap = new _706设计哈希映射.MyHashMap();

            myHashMap.Remove(27);
            myHashMap.Put(65, 65);
            myHashMap.Remove(19);
            myHashMap.Remove(0);
            Console.WriteLine(myHashMap.Get(18)); // Output: -1
            myHashMap.Remove(3);
            myHashMap.Put(42, 0);
            Console.WriteLine(myHashMap.Get(19)); // Output: -1
            myHashMap.Remove(42);
            myHashMap.Put(17, 90);
            myHashMap.Put(31, 76);
            myHashMap.Put(48, 71);
            myHashMap.Put(5, 50);
            myHashMap.Put(7, 68);
            myHashMap.Put(73, 74);
            myHashMap.Put(85, 18);
            myHashMap.Put(74, 95);
            myHashMap.Put(84, 82);
            myHashMap.Put(59, 29);
            myHashMap.Put(71, 71);
            myHashMap.Remove(42);
            myHashMap.Put(51, 40);
            myHashMap.Put(33, 76);
            Console.WriteLine(myHashMap.Get(17)); // Output: 90
            myHashMap.Put(89, 95);
            Console.WriteLine(myHashMap.Get(95)); // Output: -1
            myHashMap.Put(30, 31);
            myHashMap.Put(37, 99);
            Console.WriteLine(myHashMap.Get(51)); // Output: 40
            myHashMap.Put(95, 35);
            myHashMap.Remove(65);
            myHashMap.Remove(81);
            myHashMap.Put(61, 46);
            myHashMap.Put(50, 33);
            Console.WriteLine(myHashMap.Get(59)); // Output: 29
            myHashMap.Remove(5);
            myHashMap.Put(75, 89);
            myHashMap.Put(80, 17);
            myHashMap.Put(35, 94);
            Console.WriteLine(myHashMap.Get(80)); // Output: 17
            myHashMap.Put(19, 68);
            myHashMap.Put(13, 17);
            myHashMap.Remove(70);
            myHashMap.Put(28, 35);
            myHashMap.Remove(99);
            myHashMap.Remove(37);
            myHashMap.Remove(13);
            myHashMap.Put(90, 83);
            myHashMap.Remove(41);
            Console.WriteLine(myHashMap.Get(50)); // Output: 33
            myHashMap.Put(29, 98);
            myHashMap.Put(54, 72);
            myHashMap.Put(6, 8);
            myHashMap.Put(51, 88);
            myHashMap.Remove(13);
            myHashMap.Put(8, 22);
            Console.WriteLine(myHashMap.Get(85)); // Output: 18
            myHashMap.Put(31, 22);
            myHashMap.Put(60, 9);
            Console.WriteLine(myHashMap.Get(96)); // Output: -1
            myHashMap.Put(6, 35);
            myHashMap.Put(54, 72);
            myHashMap.Put(15, 7);
            myHashMap.Put(28, 51);
            myHashMap.Put(51, 80);
            myHashMap.Put(58, 92);
            myHashMap.Put(13, 12);
            Console.WriteLine(myHashMap.Get(91)); // Output: -1
            myHashMap.Put(83, 52);
            myHashMap.Put(8, 48);
            Console.WriteLine(myHashMap.Get(62)); // Output: -1
            myHashMap.Put(54, 25);
            myHashMap.Put(36, 4);
            myHashMap.Put(67, 68);
            myHashMap.Put(83, 36);
            Console.WriteLine(myHashMap.Get(47)); // Output: -1
            myHashMap.Remove(82);
            myHashMap.Put(36, 30);
            myHashMap.Put(33, 87);
            myHashMap.Put(42, 18);
            myHashMap.Put(68, 83);
            Console.WriteLine(myHashMap.Get(50)); // Output: 33
            myHashMap.Remove(32);
            myHashMap.Put(78, 48);
            myHashMap.Put(90, 97);
            myHashMap.Put(95, 13);
            myHashMap.Put(15, 7);
            myHashMap.Remove(5);
            myHashMap.Remove(42);
            Console.WriteLine(myHashMap.Get(20)); // Output: -1
            myHashMap.Remove(65);
            myHashMap.Put(57, 9);
            myHashMap.Put(2, 41);
            myHashMap.Remove(6);
            Console.WriteLine(myHashMap.Get(33)); // Output: 87
            myHashMap.Put(16, 44);
            myHashMap.Put(95, 30);
            Console.ReadKey();
        }
    }
}