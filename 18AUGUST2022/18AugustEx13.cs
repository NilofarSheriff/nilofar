using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose to convert \n 1.Kilometre \n 2.metre");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    
                    Console.WriteLine("Enter the metre");
                    int a = Convert.ToInt32(Console.ReadLine());
                    kilometre(a);
                    break;
                case 2:

                    Console.WriteLine("Enter the Kilometre");
                    a = Convert.ToInt32(Console.ReadLine());
                    metre(a);
                    break;

            }
            Console.ReadLine();
            
        }
        static void kilometre(float a)
        {
            double b = Convert.ToDouble(a / 1000);
            Console.WriteLine("The converted Kilometre is " + b +"Km");

        }

        static void metre(float a)
        {
            double b = a * 1000;
            Console.WriteLine("The converted metre is "+b+"m");
        }

    }
}
