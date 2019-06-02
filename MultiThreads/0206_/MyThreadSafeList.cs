using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0206_
{
    class MyThreadSafeList
    {

        List<int> numbers = new List<int>();
        object keyNumber1 = new object();

        List<int> digits = new List<int>();
        object keyNumber2 = new object();

        // solution 1- System.Collections.Concurrent
        //static System.Collections.Concurrent.ConcurrentDictionary <int> numbers = new ConcurrentBag<int>();
        IList list = ArrayList.Synchronized(new List<int>());
        
        public void Add()
        {

            // do not allow more than 1 thread to enter here!!
            // open ILDASM and see: lock actually creates: Monitor.Enter try  {  } finally { Monitor.Exit }
            lock (keyNumber1)
            {
                numbers.Add(1);
            }
            
        }
        public void Remove()
        {
            // do not allow more than 1 thread to enter here!!
            Monitor.Enter(keyNumber1);

            numbers.RemoveAt(0);

            Monitor.Exit(keyNumber1); // if you forget Monitor.Exit --> dead lock!!
        }

        public void AddDigit()
        {
            // do not allow more than 1 thread to enter here!!
            Monitor.Enter(keyNumber2);

            digits.Add(1);

            Monitor.Exit(keyNumber2);
        }
        public void RemoveDigit()
        {
            // do not allow more than 1 thread to enter here!!
            Monitor.Enter(keyNumber2);

            digits.RemoveAt(0);

            Monitor.Exit(keyNumber2);
        }
    }
}
