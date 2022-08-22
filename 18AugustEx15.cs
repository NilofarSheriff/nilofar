using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the US dollar to convert to Indian Rupees");
            double a = Convert.ToDouble(Console.ReadLine());
            double india = a * 79.60;
            Console.WriteLine("The converted Indian Rupee = {0}Rs.", india);
            Console.ReadLine();
        }
    }
}
