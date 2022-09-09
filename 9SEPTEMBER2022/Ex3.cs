using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9September
{
    internal class Ex3
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
           
            Threadmethods d = new Threadmethods();
            Thread t2 = new Thread(Threadsecond);
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t2.Start();
            t1.Start();
            

            Console.WriteLine("End");


            Console.ReadLine();
        }
    }
}
