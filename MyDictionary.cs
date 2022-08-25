using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<K, V>
    {
        KeyValuePair<K, V>[] items;

        public MyDictionary()
        {
            items = new KeyValuePair<K, V>[0];
        }

        public void Add(K key, V value)
        {
            KeyValuePair<K, V>[] tempArray = items;

            items = new KeyValuePair<K, V>[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = new KeyValuePair<K, V>(key, value);
        }

        private bool CheckIfKeyExist(K key)
        {
            bool found = false;
            foreach (var item in items)
            {
                if (item.Key.Equals(key))
                {
                    found = true;
                }
            }
            return found;

        }
        public void ListItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }
        public int Count
        { 
            get { return items.Length; }
        }
    }

}

