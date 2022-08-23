using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class _23AugustEx7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for i") ;
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            int j = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("The divison performed");
                int z = i / j;
                Console.WriteLine("z is :" +z);

            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

               

            }
            finally
            {
                Console.WriteLine("finally fired");
            }
            Console.ReadLine();

        }
    }
}
