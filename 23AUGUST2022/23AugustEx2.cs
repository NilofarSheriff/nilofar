using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class August23Ex2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter A value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B value");
            int b = Convert.ToInt32(Console.ReadLine());
            add(a, b);
            Console.WriteLine("The sum of a={0} and b={1} is c={2}", a, b, add(a,b));
            Console.ReadLine();



        }
        static int add(int a, int b)
        {
            int sum = a + b;
            //Console.WriteLine("The sum of a={0} and b={1} is c={2}", a, b, sum);
            return sum;
        }

    }
}
