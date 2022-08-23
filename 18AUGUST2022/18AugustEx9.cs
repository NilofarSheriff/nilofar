using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelvin2fh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius");
            int a = Convert.ToInt32(Console.ReadLine());
            double k = a + 273.15;
            Console.WriteLine("Kelvi = "+k);
            int f =  ((a * 9 / 5) + 32);
            Console.WriteLine("Farenheit = " + f);
            Console.ReadLine(); 
        }
    }
}
