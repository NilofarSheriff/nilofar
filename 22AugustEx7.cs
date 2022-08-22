using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before DEQUEING");
            Queue Q = new Queue();
            Q.Enqueue(100);
            Q.Enqueue("Nilofar");
            Q.Enqueue(new DateTime());
            Q.Enqueue("Sheriff");
            int qcount = Q.Count;
            Console.WriteLine("The total count of the queue is "+qcount);
            Object[] obj;
            obj = Q.ToArray();
            
            foreach( var item in obj ){
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************************************");
            Q.Dequeue();
            Q.Dequeue();
            Console.WriteLine("After DEQUEING");
            qcount = Q.Count;
            Console.WriteLine("The total count of the queue is " + qcount);
            obj = Q.ToArray();
           
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            
            Object qpeek = Q.Peek();
            Console.WriteLine("The peek value in the queue is "+qpeek);
            Console.ReadLine();









        }
    }
}
