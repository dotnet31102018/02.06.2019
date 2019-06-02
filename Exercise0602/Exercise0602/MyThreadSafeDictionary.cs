using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0602
{
    class MyThreadSafeDictionary<K, V> : IMyDictionary<K, V>
    {
        private Dictionary<K, V> items = new Dictionary<K, V>();
        public void Add(K key, V value)
        {
            lock (this)
            {
                items.Add(key, value);
            }
        }

        public V Get(K key)
        {
            lock (this)
            {
                items.TryGetValue(key, out V value);
                return value;
            }
        }

        public void Remove(K key)
        {
            lock (this)
            {
                items.Remove(key);
            }
        }
    }
}
