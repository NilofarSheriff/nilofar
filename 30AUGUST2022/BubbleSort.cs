using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            BubbleSortfn(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void BubbleSortfn(int[] arr1)
        {
            int i, j, temp;
            temp = 0;
            for(i=0; i<arr1.Length; i++)
            {
                for (j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
        }

    }
}
