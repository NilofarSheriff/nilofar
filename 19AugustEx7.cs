using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks for three subjects");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = a + b + c;
            int total = d / 3;

            if (total < 35)
            {
                Console.WriteLine("Fail");
            }

            else if ((total >= 35) && (total < 45))
            {
                Console.WriteLine("Third Rank");
            }
            else if ((total >= 45) && (total < 60))
            {
                Console.WriteLine("Second Rank");
            }
            else
            {
                Console.WriteLine("First Rank");
            }

            Console.ReadLine();




        }
    }
}
