using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two strings");

            string str1=Console.ReadLine();
               
            string str2=Console.ReadLine();

            Console.WriteLine("you entered {0} amd {1}",str1, str2);

            if (str1==str2)
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");

            }
            Console.ReadLine();

        }
    }
}
