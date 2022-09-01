using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1September
{
    internal class _1SeptemberExno1_Shell_Sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {45,12,85,65,25,63,52,8,2 };
            Console.WriteLine("Before sorting");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            ShellSort(arr);
            Console.WriteLine("After sorting");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        static void ShellSort(int[] arr)
        {
            int temp;
            int n = arr.Length;
            for(int gap = (n*3)+1; gap>=1; gap=gap/2)
            {
                for(int i=gap; i < n; i++)

                {
                   
                    for(int j=i-gap; j>=0; j=j-gap)
                    {
                        if (arr[j+gap] > arr[j])
                        {
                            break;
                        }
                        else
                        {
                            temp = arr[j];
                            arr[j] = arr[j+gap];
                            arr[j+gap] = temp;
                        }
                    }
                }

            }

        }
    }
}
