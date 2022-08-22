using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _22AugustEx13
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("The values greater than 100: ");
            foreach(int i in list1.Where(k => k > 100)){
                Console.WriteLine(i);
            }
            Console.ReadLine();
            

        }
    }
}
