using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0,k, userchoice;
            // Int32 Y;
            //float Pi = 3;


            Console.WriteLine("Menu\n 1.Add \n 2.Sub \n 3. Exit");
            userchoice= Convert.ToInt32(Console.ReadLine());
            if (userchoice !=3)
            {
                Console.WriteLine("enter the value for i again");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter value for J again");
                j = Convert.ToInt32(Console.ReadLine());
            }
           

            switch (userchoice)
            {
                case 1:
                   k = i+ j;
                    Console.WriteLine(k);
                    break;
                case 2:
                   k = i - j;
                   Console.WriteLine(k);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Enter a valid Userchoice");
                    break;
            }
            

            
        }
    }
}
