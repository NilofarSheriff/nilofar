using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_number
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the value");
            int a =Convert.ToInt32(Console.ReadLine());
            int i=0;
            while(i < 2){
                Console.WriteLine("{0} {0} {0} {0}",a);
                Console.WriteLine("{0}{0}{0}{0}",a);
                i++;
            }
            Console.ReadLine();
        }
    }
}
