using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class EXERCISE2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any three numbers to check maximum and minimum numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The three numbers are {0}, {1} and {2}", a, b, c);

            if ((a > b) && (a > c))
            {
                Console.WriteLine("a={0} is the greatest number", a);


            }
            else if ((b > c) && (b > a))
            {
                Console.WriteLine("b={0} is the greatest number", b);

            }
            else
            {
                Console.WriteLine("c={0} is the greatest number", c);
            }
            Console.ReadLine();
        }
    }
}
