using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex8
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"Ponniyin Selvan");
            ht.Add(2, "Alchemist");
            ht.Add(3, "Journey to the centre of the Earth");
            ht.Add(4, "Sleeping beauty");

            Console.WriteLine("BEFORE DELETING");
            IDictionaryEnumerator ie=ht.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key+" "+ie.Value);
            }
            Console.WriteLine("**************************************************");
            Console.WriteLine("AFTER DELETING THE ID 3");
            ht.Remove(3);
            IDictionaryEnumerator val= ht.GetEnumerator();
            while (val.MoveNext())
            {
                Console.WriteLine(val.Key + " " + val.Value);
            }
            Console.ReadLine();



        }
    }
}
