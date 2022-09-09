using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9September
{
    internal class EX4_A
    {
        static void Main(string[] args)
        {
            using (Mutex mut = new Mutex(true,"Thread")){
                if (mut.WaitOne(5,true))
                {
                    Console.WriteLine("Hey I'm at Mutex");
                    Console.WriteLine("Already Running");
                    Console.Read();
                    return;

                }
                else
                {
                    Console.WriteLine("Running");
                    Console.Read();

                }

            }
        }


    }
}
