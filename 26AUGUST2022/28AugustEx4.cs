using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26August
{
    internal class Linkedlistdemo
    {
        static void Main(string[] args)
        {
            #region linkedlistint
            //linkedlist<int> l1 = new linkedlist<int>();
            //l1.addfirst(1);
            //l1.addlast(100);
            //l1.addafter(l1.first, 20);
            //l1.addbefore(l1.last, 90);
            //l1.addbefore(l1.last.previous, 180);
            //l1.addafter(l1.first.next, 30);
            //linkedlistnode<int> findnode = l1.find(30);
            ////linkedlistnode<int> findnode = l1.last;

            //findnode.value = 27;
            //foreach (int i in l1)
            //{
            //    console.writeline(i);
            //}
            #endregion

            LinkedList<String> str = new LinkedList<String>();
            str.AddFirst("Nilo");
            str.AddLast("Sheriff");
            str.AddAfter(str.First, "Mehar");
            str.AddAfter(str.First.Next, "Jabeen");
            str.AddAfter(str.First.Next.Next, "Ayan");
            str.AddBefore(str.Last, "Khalaq");
            str.AddBefore(str.Last.Previous, "Mohamed");
            str.AddBefore(str.Last.Previous.Previous, "Aayudha");
            LinkedListNode<String> find1 = str.Find("Jabeen");
            find1.Value = "Zamruth Banu";

            foreach (var i in str)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
