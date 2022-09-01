using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1September
{
    internal class _1SeptemberEx2MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45, 12, 85, 65, 25, 63, 52, 8, 2 };
            Console.WriteLine("Before sorting");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            MergeSort(arr);
            Console.WriteLine("After sorting");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

        static void MergeSort(int[] C)

        {
            int beg = 0, end = C.Length - 1;
            int mid = (beg + end) / 2;
            int n1 = mid - beg + 1;
            int n2 = end - mid;



            if (C.Length > 1)
            {
                int[] A = new int[n1];
                int[] B = new int[n2];
                

                for (int i1 = 0; i1 < n1; i1++)
                {
                   A[i1] = C[beg + i1];
                    for (int j1 = 0; j1 < n2; j1++)
                    {
                        B[j1] = C[mid + 1 + j1];
                    }
                }
                
                MergeSort(A);
                MergeSort(B);
                int i = 0; int j = 0; int k = beg;
                while (i < n1 && j < n2)
                {
                    if (A[i] < B[j])
                    {
                        C[k] = A[i];
                        i = i + 1;
                        k = k + 1;

                    }
                    else
                    {
                        C[k] = B[j];
                        j = j + 1;
                        k = k + 1;

                    }

                }
                while (i < n1)
                {
                    C[k] = A[i];
                    i = i + 1;
                    k = k + 1;
                }
                while (j < n2)
                {
                    C[k] = B[j];
                    j = j + 1;
                    k = k + 1;

                }
            }


            

        }
    }
}
