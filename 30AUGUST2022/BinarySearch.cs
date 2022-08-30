using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _30August
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            BubbleSortfn(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the value to find in binary search");
            int key = int.Parse(Console.ReadLine());
            BinarySearchfn(arr, key);
            Console.ReadLine();


        }
        static void BubbleSortfn(int[] arr1)
        {
            int i, j, temp;
            temp = 0;
            for (i = 0; i < arr1.Length; i++)
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
        static void BinarySearchfn(int[] arr1, int key)
        {
            int start = 0, end = arr1.Length, mid;
            
            while(start <= end)
            {
                mid = (start + end) / 2;
                if (arr1[mid] == key)
                {
                    Console.WriteLine("{0} found at the position {1}", arr1[mid], mid);
                    break;
                   
                    
                }

                else if (arr1[mid] < key)
                {
                    start = mid + 1;
                    
                }
                else if (arr1[mid] > key)
                {
                    end = mid - 1;
                    
                }
               
               
            }
            
            

        }
    }
}
