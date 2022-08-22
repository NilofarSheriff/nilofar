using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Excersie6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year to check leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }

            else
            {
                Console.WriteLine("{0} is a not Leap Year", year);
            }
            Console.ReadLine();
        }
    }
}
