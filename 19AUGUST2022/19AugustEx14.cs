using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Menu \n 1.Check the input \n 2.Exit");

            int userchoice=Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    {

                        if (a == 0)
                        {
                            Console.WriteLine("Input is Zero");

                        }
                        else if (a > 100)
                        {
                            Console.WriteLine("Too large input");
                        }
                        else if (a % 2 != 0)
                        {
                            Console.WriteLine("Input {0} is odd Number", a);

                        }
                        else if (a % 2 == 0)

                        {
                            if (a % 10 == 0)
                            {
                                Console.WriteLine("Input {0} is a Multiple of 10", a);

                            }
                            else
                            {
                                Console.WriteLine("Input {0} is Even Number", a);
                            }
                            
                        }
                        break;
                    }
                case 2:
                    {
                        Environment.Exit(0);
                        break;

                    }
                 
                       
                  
            }
            Console.ReadLine();
        }
    }
}
