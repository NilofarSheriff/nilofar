using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, -41, 3, 12, 57, -13, 69, 23, 56 };
            InsertedSortfn(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
         static void InsertedSortfn(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
               int temp = arr[i];
                int j;
                j = i - 1;
                while( (j>=0) && (arr[j] > temp))
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = temp;

            }
        }
    }

}
