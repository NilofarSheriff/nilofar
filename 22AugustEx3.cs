using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int sum=0;

            Console.WriteLine("Enter the value to be in the array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("enter value for a[{0}]", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("******You entered*****");

            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
            Console.Read();




        }

    }
}

