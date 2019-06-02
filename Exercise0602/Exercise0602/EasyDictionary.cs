using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0602
{
    class EasyDictionary<K, V> : IMyDictionary<K, V>
    {
        private ConcurrentDictionary<K, V> items = new ConcurrentDictionary<K, V>();

        public void Add(K key, V value)
        {
            items.TryAdd(key, value);
        }

        public V Get(K key)
        {
            items.TryGetValue(key, out V value);
            return value;
        }

        public void Remove(K key)
        {
            items.TryRemove(key, out V value);
        }
    }
}
