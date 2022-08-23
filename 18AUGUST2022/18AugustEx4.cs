using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth value");
            int d = Convert.ToInt32(Console.ReadLine());
            int add = (a + b + c + d);
            float avg = add / 4;
            Console.WriteLine( "The average of {0} + {1} + {2} + {3} = {4}", a,b,c,d,avg);
            Console.ReadLine();
            
            
        }
    }
}
