using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Uppercase
    {
        public static void uppercase(string a)
        {
            string b= a.ToUpper();
            Console.WriteLine("The uppercase of the given string {0} is {1}",a,b);
            Console.ReadLine();
        }
    }
}
