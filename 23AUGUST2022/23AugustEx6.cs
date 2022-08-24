using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class _23AugustEx6
    {
        static void Main(string[] args)
        {
            
            
            string dept_name = " ";
            Console.WriteLine("Enter deptname");
            dept_name = Console.ReadLine();
            int k;

            switch (dept_name)
            {
                case "Purchase":
                    k = (int)deptnames.Purchase;
                    Console.WriteLine(k);
                    break;
                case "Sales":
                    k = (int)deptnames.Sales;
                    Console.WriteLine(k);
                    break;
                case "Training":
                    k = (int)deptnames.Training;
                    Console.WriteLine(k);
                    break;
                case "Accounts":
                    k = (int)deptnames.Accounts;
                    Console.WriteLine(k);
                    break;
                default:
                    break;

            }

            Console.ReadLine();




        }

        enum deptnames
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Accounts = 4
        }


    }
}
