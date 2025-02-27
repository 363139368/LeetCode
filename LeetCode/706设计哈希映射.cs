// namespace LeetCode
// {
//     public class _706设计哈希映射
//     {
//         public class MyHashMap
//         {
//             public HashmapItem[] items;
//
//             public int count;
//
//             public MyHashMap()
//             {
//                 items = new HashmapItem[8];
//             }
//
//             public void Put(int key, int value)
//             {
//                 if ((float)count / (float)(items.Length) > 0.8f)
//                 {
//                     // todo 扩容
//                 }
//
//                 var index = key % GetCurFacter();
//
//                 if (items[index] == null)
//                 {
//                     items[index] = new HashmapItem()
//                     {
//                         key = key,
//                         value = value,
//                         Index = index,
//                         NextIndex = -1
//                     };
//                     count++;
//                     return;
//                 }
//
//                 if (items[index].key == key)
//                 {
//                     items[index].value = value;
//                     return;
//                 }
//
//                 var last = index;
//                 var nextIndex = items[index].NextIndex;
//                 var linkTimer = 0;
//                 while (true)
//                 {
//                     linkTimer++;
//
//                     if (linkTimer >= 10)
//                     {
//                         // todo 扩容
//                         return;
//                     }
//                 }
//             }
//
//             public int Get(int key)
//             {
//             }
//
//             public void Remove(int key)
//             {
//                 count--;
//             }
//
//             private void rehash()
//             {
//             }
//
//             private int GetCurFacter()
//             {
//                 return (items.Length / 2) + 1;
//             }
//         }
//
//         public class HashmapItem
//         {
//             public int key;
//             public int value;
//             public int Index;
//             public int NextIndex;
//         }
//
//         // /**
//         //  * Your MyHashMap object will be instantiated and called as such:
//         //  * MyHashMap obj = new MyHashMap();
//         //  * obj.Put(key,value);
//         //  * int param_2 = obj.Get(key);
//         //  * obj.Remove(key);
//         //  */
//     }
// }