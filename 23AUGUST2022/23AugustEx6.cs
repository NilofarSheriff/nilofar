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
            
            
            
            var deptno = (int)deptnames.Sales;
            Console.WriteLine("The dept no of the department Purchase is = {0}",deptno);
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
