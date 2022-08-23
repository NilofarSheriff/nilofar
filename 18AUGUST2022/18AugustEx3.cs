using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic1
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("menu\n 1.add\n 2.sub\n 3.multiply \n 4.division");
            int userchoice=Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    int c = a + b;
                    Console.WriteLine(c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine(c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine(c);
                    break;
                case 4:
                   c = a / b;
                    Console.WriteLine(c);
                    break;

                //default:
                   // Environment.ExitCode = 1;

            }
            Console.ReadLine();

        }
    }
}
