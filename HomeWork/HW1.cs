using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0206
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Thread t = new Thread(() =>
               {
                   for (int i = 5; i >= 0; i--)
                   {
                       Console.WriteLine($"{i} seconds left....");
                       Thread.Sleep(1000);
                   }
                   Console.WriteLine("Time over...........");
               });
            t.Start();

            int result = Convert.ToInt32(Console.ReadLine());

            if (t.ThreadState != ThreadState.Stopped && result == 5 + 3)
            {
                Console.WriteLine("You are a hero!");
            }
            else
            {
                Console.WriteLine("Booooooooooooo");
            }
            t.Abort();
           
        }
    }
}
