using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9September
{
    internal class Ex2
    {
        public static void Threadintro()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I'm No : " + i);
                if (i == 5)
                {
                    Thread.Sleep(5);

                }
            }
            

        }


        public static void Threadsecond()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Im from Second Class and I'm no :" + j);
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(Threadintro);
            t1.Name = "First Thread";
            Thread t2 = new Thread(Threadsecond);
            t2.Name = "Second Thread";
            Console.WriteLine("First thread is background" + t1.IsBackground);
            Console.WriteLine("Second thread is background" + t2.IsBackground);
           
            Console.WriteLine("THE NAME OF THE TWO THREADS ARE :" + t1.Name+" "+t2.Name);
            Console.WriteLine("The state of first thread is "+t1.ThreadState);
            Console.WriteLine("The state of second thread is " + t2.ThreadState);


            t1.Start();
            
            t2.Start();
            Console.WriteLine("First thread is alive " + t1.IsAlive);
            Console.WriteLine("Second thread is alive " + t2.IsAlive);
            Console.WriteLine("The state of first thread is " + t1.ThreadState);
            Console.WriteLine("The state of second thread is " + t2.ThreadState);
            t1.Join();
            t2.Join();
            Console.WriteLine("The state of first thread is " + t1.ThreadState);
            Console.WriteLine("The state of second thread is " + t2.ThreadState);
            
           
            

            t1.Abort();
            t2.Abort();
            Console.WriteLine("The state of first thread is " + t1.ThreadState);
            Console.WriteLine("The state of second thread is " + t2.ThreadState);
            Console.WriteLine("First thread is alive " + t1.IsAlive);
            Console.WriteLine("Second thread is alive " + t2.IsAlive);



            Console.WriteLine("End");


            Console.ReadLine();
        }
    }
}
