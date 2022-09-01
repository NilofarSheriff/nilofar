using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, -41, 3, 12, 57, -13, 69, 23, 56 };
            quicksortedSortfn(arr,0,arr.Length);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
         public static void swap(int[] arr,int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapindex=start;
            for(int i=start+1; i<end; i++)
            {
                if (arr[i] < pivot)
                {
                    swapindex++;
                    swap(arr,i,swapindex);

                }
            }
            swap(arr,start,swapindex);
            return swapindex;

        } 

        public static int[] quicksortedSortfn(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = partition(arr, start, end);
                quicksortedSortfn(arr, start, pivot);
                quicksortedSortfn(arr, pivot + 1, end);
            }
            return arr;
            

        }
    }
}
