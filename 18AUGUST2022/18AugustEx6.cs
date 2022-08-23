using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + a);
            Console.ReadLine();
        }
    }
}
