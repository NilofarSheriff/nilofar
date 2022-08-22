using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _22AugustEx12
    {
        static void Main(string[] args)
        {
            int[] arr1 =new int[] { 10,40,67,98,345 };
            int n, max, min,i;
            max=arr1[0];
            min=arr1[0];

            for (i=0; i<arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
                

            }
            Console.WriteLine("The Maximum Value in the array is " + max);
            Console.WriteLine("The Maximum Value in the array is " + min);
            Console.Read();
        }
    }
}
