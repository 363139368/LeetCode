namespace LeetCode
{
    public class _706设计哈希映射
    {
        public class MyHashMap
        {
            public HashmapItem[] items;

            public int count;

            public MyHashMap()
            {
                items = new HashmapItem[8];
            }

            public void Put(int key, int value)
            {
                if ((float)count / (float)(items.Length) > 0.8f)
                {
                    rehash();
                    // todo 扩容
                }

                var index = key % GetCurFacter();

                if (items[index] == null)
                {
                    items[index] = new HashmapItem()
                    {
                        key = key,
                        value = value,
                        next = null,
                    };
                    count++;
                    return;
                }

                if (items[index].key == key)
                {
                    items[index].value = value;
                    return;
                }

                if (items[index].next == null)
                {
                    items[index].next= new HashmapItem()
                    {
                        key = key,
                        value = value,
                        next = null,
                    };
                    count++;
                    return;
                }

                var pre = items[index];
                var cur = items[index].next;
                var linkTimer = 0;
                while (true)
                {
                    if (cur != null)
                    {
                        if (cur.key == key)
                        {
                            cur.value = value;
                            return;
                        }

                        pre = cur;
                        cur = cur.next;
                    }
                    else
                    {
                        pre.next = new HashmapItem()
                        {
                            key = key,
                            value = value,
                            next = null,
                        };
                        count++;
                        return;
                    }
                    
                    linkTimer++;

                    if (linkTimer >= 10)
                    {
                        // todo 扩容
                        rehash();
                        Put(key, value);
                        return;
                    }
                }
            }

            public int Get(int key)
            {
                var index = key % GetCurFacter();
                if (items[index] == null)
                {
                    return -1;
                }

                if (items[index].key == key)
                {
                    return items[index].value;
                }


                var pre = items[index];
                var cur = items[index].next;
                while (cur != null)
                {
                    if (cur.key == key)
                    {
                        return cur.value;
                    }
                    pre = cur;
                    cur = cur.next;
                }
                
                return -1;
            }

            public void Remove(int key)
            {
                var index = key % GetCurFacter();
                if (items[index] == null)
                {
                    return;
                }

                if (items[index].key == key)
                {
                    items[index] = items[index].next;
                    count--;
                }
                else
                {
                    var pre = items[index];
                    var cur = items[index].next;
                    while (cur != null)
                    {
                        if (cur.key == key)
                        {
                            pre.next = cur.next;
                            count--;
                            return;
                        }
                        
                        pre = cur;
                        cur = cur.next;
                    }
                }
            }

            private void rehash()
            {
                HashmapItem[] oldItems = items;
                items = new HashmapItem[oldItems.Length * 2];
                for (int i = 0; i < oldItems.Length; i++)
                {
                    if (oldItems[i] != null)
                    {
                        Put(oldItems[i].key, oldItems[i].value);
                        
                        var cur = oldItems[i].next;
                        while (cur != null)
                        {
                            Put(cur.key, cur.value);
                            cur = cur.next;
                        }
                    }
                }
            }

            private int GetCurFacter()
            {
                return (items.Length / 2) + 1;
            }
        }

        public class HashmapItem
        {
            public int key;
            public int value;
            public HashmapItem next = null;
        }

        // /**
        //  * Your MyHashMap object will be instantiated and called as such:
        //  * MyHashMap obj = new MyHashMap();
        //  * obj.Put(key,value);
        //  * int param_2 = obj.Get(key);
        //  * obj.Remove(key);
        //  */
    }
}