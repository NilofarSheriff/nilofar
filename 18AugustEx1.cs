using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 6;
            Console.WriteLine("Before swapping");
            Console.WriteLine("i=" +i);
            Console.WriteLine("j=" + j);
            Console.WriteLine("------------callby value---------------");
            callbyvalue(i, j);
            Console.WriteLine();
            Console.WriteLine("----Now call by reference---------");
            callbyrefeg(ref i, ref j);
            Console.ReadLine();




        }
        static void callbyvalue(int i, int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After swapping");
            Console.WriteLine("i="+i);
            Console.WriteLine("j="+j);
            


        }

        static void callbyrefeg(ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After swapping");
            Console.WriteLine("i=" + i);
            Console.WriteLine("j=" + j);
        }
    }
}
