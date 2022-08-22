using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the N value");
            int n =Convert.ToInt32(Console.ReadLine());
            int sum = 0, i=0;

            
            for(i=1; i<=n; i++)
            {
                if (i % 2 != 0)
                {
                     

                    Console.WriteLine(i);
                    sum = sum +i;
                }

                
            }
            Console.WriteLine("The total sum of natural numbers upto {0} is {1}", n, sum);
            Console.ReadLine();
            
          
        }
    }
}
