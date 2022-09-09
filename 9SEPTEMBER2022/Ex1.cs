using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace _9September
{
    class Threadmethods
    {
        public static void Threadintro()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("I'm No : " +i);
                if (i == 5)
                {
                    Thread.Sleep(5);

                }
            }

        }

        public static void Threadsecond()
        {
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("Im from Second Class and I'm no :" +j);
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(Threadintro);
            t1.Start();
            Threadmethods d = new Threadmethods();
            Thread t2 = new Thread(Threadsecond);
            t2.Start();

            Console.WriteLine("End");
            
           
            Console.ReadLine();
        }
    }
}
