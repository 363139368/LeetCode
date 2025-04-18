﻿namespace LeetCode
{
    internal class StringHashCode
    {
        // BKDR Hash Function
        public static int Hash1(string str)
        {
            var seed = 131; // 31 131 1313 13131 131313 etc..
            var hash = 0;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            while (count > 0)
            {
                hash = hash * seed + bitarray[bitarray.Length - count];
                count--;
            }

            return hash & 0x7FFFFFFF;
        }

        //AP hash function
        public static int Hash2(string str)
        {
            var hash = 0;
            int i;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            for (i = 0; i < count; i++)
            {
                if ((i & 1) == 0)
                    hash ^= (hash << 7) ^ bitarray[i] ^ (hash >> 3);
                else
                    hash ^= ~((hash << 11) ^ bitarray[i] ^ (hash >> 5));
                count--;
            }

            return hash & 0x7FFFFFFF;
        }

        //SDBM Hash function
        public static int Hash3(string str)
        {
            var hash = 0;
            int i;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;

            while (count > 0)
            {
                // equivalent to: hash = 65599*hash + (*str++);
                hash = bitarray[bitarray.Length - count] + (hash << 6) + (hash << 16) - hash;
                count--;
            }

            return hash & 0x7FFFFFFF;
        }

        // RS Hash Function
        public static int Hash4(string str)
        {
            var b = 378551;
            var a = 63689;
            var hash = 0;

            int i;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            while (count > 0)
            {
                hash = hash * a + bitarray[bitarray.Length - count];
                a *= b;
                count--;
            }

            return hash & 0x7FFFFFFF;
        }

        // JS Hash Function
        public static int Hash5(string str)
        {
            var hash = 1315423911;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            while (count > 0)
            {
                hash ^= (hash << 5) + bitarray[bitarray.Length - count] + (hash >> 2);
                count--;
            }

            return hash & 0x7FFFFFFF;
        }

        // P. J. Weinberger Hash Function
        public static int Hash6(string str)
        {
            var BitsInUnignedInt = sizeof(int) * 8;
            var ThreeQuarters = BitsInUnignedInt * 3 / 4;
            var OneEighth = BitsInUnignedInt / 8;
            var hash = 0;
            unchecked
            {
                var HighBits = (int)0xFFFFFFFF << (BitsInUnignedInt - OneEighth);
                var test = 0;
                int count;
                var bitarray = str.ToCharArray();
                count = bitarray.Length;
                while (count > 0)
                {
                    hash = (hash << OneEighth) + bitarray[bitarray.Length - count];
                    if ((test = hash & HighBits) != 0) hash = (hash ^ (test >> ThreeQuarters)) & ~HighBits;
                    count--;
                }
            }

            return hash & 0x7FFFFFFF;
        }

        // ELF Hash Function
        public static int Hash7(string str)
        {
            var hash = 0;
            var x = 0;
            int i;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            unchecked
            {
                while (count > 0)
                {
                    hash = (hash << 4) + bitarray[bitarray.Length - count];
                    if ((x = hash & (int)0xF0000000) != 0)
                    {
                        hash ^= x >> 24;
                        hash &= ~x;
                    }

                    count--;
                }
            }

            return hash & 0x7FFFFFFF;
        }

        // DJB Hash Function
        public static int Hash8(string str)
        {
            var hash = 5381;
            int i;
            int count;
            var bitarray = str.ToCharArray();
            count = bitarray.Length;
            while (count > 0)
            {
                hash += (hash << 5) + bitarray[bitarray.Length - count];
                count--;
            }

            return hash & 0x7FFFFFFF;
        }


        #region MyHashFun

        public static int DJBHash(string str)
        {
            var hash = 0;
            var bit = str.ToCharArray();
            for (var i = 0; i < bit.Length; i++)
                hash += (hash << 5) + hash + bit[i];
            return hash & 0x7FFFFFFF;
        }

        #endregion
    }
}