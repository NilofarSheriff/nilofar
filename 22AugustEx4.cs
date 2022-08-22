using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            var arrlist1 = new ArrayList();
            arrlist1.Add(1);
            arrlist1.Add("Nilofar");
            arrlist1.Add(" ");
            arrlist1.Add(true);
            arrlist1.Add(4.5);

            arrlist1.Add(55)
                ;
            int countarr = arrlist1.Count;
            Console.WriteLine("The total count of array list is ={0}", countarr);
           
            foreach (var item in arrlist1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing 55");

            Console.WriteLine("**************************");


            arrlist1.Remove(55);
           countarr=  arrlist1.Count;

            foreach (var item in arrlist1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The total count of array list is ={0}", countarr);
            Console.ReadLine();

        }
    }
}
