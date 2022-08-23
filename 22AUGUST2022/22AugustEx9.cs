using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex9
    {
        static void Main(string[] args)
        {
            List<float> list1 = new List<float>();
            list1.Add(45.45f);
            list1.Add(32.567f);
            list1.Add(76.45f);
            list1.Add(27.07f);

            foreach (float item in list1)
            {
                Console.WriteLine("The added items are :");
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
