using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _22AugustEx11
    {
        static void Main(string[] args)
        {
            SortedList<int, string> dict1 = new SortedList<int, string>();
            dict1.Add(23, "Althaf");
            dict1.Add(01, "Rasikas");
            dict1.Add(36, "Alarab");
            dict1.Add(14, "Crescent");
            
            Console.WriteLine("The added pairs in Sorted List are: ");

            foreach (KeyValuePair<int, string> item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            
            
            Console.ReadKey();
        }
    
    }
}
