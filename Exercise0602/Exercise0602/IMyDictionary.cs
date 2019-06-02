using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0602
{
    interface IMyDictionary<K, V>
    {
        void Add(K key, V value);
        void Remove(K key);
        V Get(K key);

    }
}
