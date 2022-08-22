using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex6
    {
        static void Main(string[] args)
        {
            Stack S = new Stack();
            S.Push(1);
            S.Push("nilo");
            S.Push(34.54f);
            S.Push(900);
            S.Push(new DateTime(2001, 10, 27));

            Console.WriteLine("Before Poping");

            object[] obj = S.ToArray();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            int counts = S.Count;
            Console.WriteLine("The total count of the object is {0}", counts);
            Console.WriteLine("***************************************************");

            Console.WriteLine("After Poping");
            S.Pop();
            S.Pop();
            obj = S.ToArray();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            object p = S.Peek();//returns datetime
            Console.WriteLine("The peeked value is "+ p);
            counts =S.Count;
            Console.WriteLine("The total count of the object is {0}",counts);
            Console.Read();









        }
    }
}
