using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers to check maximum and minimum numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The two numbers are {0} and {1}", a, b);
            if (a > b)
            {
                Console.WriteLine("a={0} is the biggest number", a);
                

            }
            else
            {
                Console.WriteLine("b={0} is the biggest number", b);
                
            }
            Console.ReadLine();
        }
    }
}
