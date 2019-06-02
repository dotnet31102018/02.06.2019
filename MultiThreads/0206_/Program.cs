using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace _0206_
{
    class Program
    {


        static void Main(string[] args)
        {
            MyThreadSafeList list = new MyThreadSafeList();

            for (int i = 0; i < 20; i++)
            {
                new Thread(() => { list.Add(); }).Start();
               // new Thread(() => { list.Remove(); }).Start();
            }
        }
    }
}
