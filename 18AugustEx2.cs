using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number to multiply");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the secomd number to multiply");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the third number to multiply");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a * b * c;
            Console.WriteLine("{0} *{1} *{2} = {3} ",a,b,c,d);
            Console.ReadLine();
            
        }
    }
}
