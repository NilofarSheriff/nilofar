using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];

            Console.WriteLine("Enter the value to be in the array");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("enter value for a[{0}]", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("******You entered*****");

            foreach(var i in arr1)
            {
                Console.WriteLine(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
