using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associate1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUMBER");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THIRD NUMBER");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = (a + b) * c;

            Console.WriteLine(d);
            int e = (a * b) + (b * c);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
