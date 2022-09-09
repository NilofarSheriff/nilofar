using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9September
{
    public class EX5B
    {
        static Thread[] threads = new Thread[15];
        static Semaphore sem = new Semaphore(5, 5);
        static void executecode()
        {
            Console.WriteLine("{0} is waiting", Thread.CurrentThread.Name);
            sem.WaitOne();
            Thread.Sleep(100);
            Console.WriteLine("{0}is running", Thread.CurrentThread.Name);
            sem.Release();
            Console.WriteLine("{0} has ended", Thread.CurrentThread.Name);


        }
        static void Main(string[] args)
        {
            
            for(int i =0;i<15; i++)
            {
                threads[i] = new Thread(executecode);
                threads[i].Name = "Thread" + i;
                threads[i].Start();
               

            }
            Console.ReadLine();
        }
    }
}
