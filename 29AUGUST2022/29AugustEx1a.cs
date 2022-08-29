using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    internal class _29AugustEx1a
    {
        static void Main(string[] args)
        {
            //MyGenericArray<int> intArray = new MyGenericArray<int>(5)
            Userstack<int> sample = new Userstack<int>(100);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The stack is empty" + sample.isempty());
            Console.ForegroundColor = ConsoleColor.Red;
            sample.displaydetails();
            sample.Stackpush(30);
            sample.Stackpush(40);
            sample.Stackpush(50);
            sample.Stackpush(60);
            sample.Stackpush(70);
            sample.Stackpush(80);
            sample.Stackpush(90);
            Console.ForegroundColor = ConsoleColor.Blue;
            sample.displaydetails();
            sample.Stackpop();
            sample.Stackpop();
            sample.Stackpop();
            sample.displaydetails();
            Console.ForegroundColor = ConsoleColor.Green;
            sample.Stackpeek();
            
            Console.Read();



        }
    }
}
