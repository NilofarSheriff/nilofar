using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9September
{
    internal class Ex5A
    {
        public static Mutex mut = new Mutex();
        const int n=2;
        const int loop=4;

        public static void firstcode()
        {
            for (int i = 0; i < n; i++)
            {
                secondcode();
            }

        }
        public static void secondcode()
        {
           mut.WaitOne();
            Console.WriteLine("{0} has started to run",Thread.CurrentThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("{0} has waiting", Thread.CurrentThread.Name);
            mut.ReleaseMutex();
            Console.WriteLine("{0} has ended",Thread.CurrentThread.Name);


        }

        static void Main(string[] args)
        {
            for(int i = 0; i < loop; i++)
            {
                Thread thr = new Thread(firstcode);
                thr.Name = String.Format("Thread{0}", i + 1);
                thr.Start();
            }
            Console.ReadLine();
        }
    }
}
