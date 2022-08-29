using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    internal class _29AugustEx2
    {
        static void Main(string[] args)
        {
            UserQueue sample = new UserQueue(10);
            Console.WriteLine("Before adding");
            Console.WriteLine("_____________________________");
            sample.displaydetails();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_____________________________");
            sample.Queueenqueue(7);
            sample.Queueenqueue(45);
            sample.Queueenqueue(81);
            sample.Queueenqueue(6);
            sample.Queueenqueue(41);
            sample.Queueenqueue(23);
            sample.Queueenqueue(27);
            Console.WriteLine("_____________________________");
            Console.WriteLine("After Adding");
            sample.displaydetails();
           

            sample.Queuedequeue();
            sample.Queuedequeue();
            sample.Queuedequeue();
            Console.WriteLine("_____________________________");
            Console.ForegroundColor = ConsoleColor.Blue;

            sample.displaydetails();
            Console.ForegroundColor=ConsoleColor.Red;

            Console.WriteLine("showing peek value");
            sample.peekqueue();
            Console.WriteLine("_____________________________");

            Console.ReadLine();










        }
    }
}
