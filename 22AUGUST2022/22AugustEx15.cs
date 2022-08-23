using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _22AugustEx14
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 3, 4, 3, 5, 6 };
            HashSet<int> set = new HashSet<int>();
            int min = 0; int i; 
            
            for (i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                {
                    min = i;
                  
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
            var index = Array.FindIndex(arr,n => n == min);
            if (min != 0)
            {
                Console.WriteLine("The first repeating element is {0} at the position {1}", arr[min], index);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();
        }
    }
}
