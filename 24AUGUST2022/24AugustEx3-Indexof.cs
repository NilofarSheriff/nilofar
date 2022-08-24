using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Indexof
    {
        public static void Indexofstr(string a)

        {
            Console.WriteLine("Enter the letter to check the index from the string " + a);
            char ch = Convert.ToChar(Console.ReadLine());
            int i = a.IndexOf(ch);
            Console.WriteLine("The index of {0} in the given string {2} is {1}",ch,i,a);
            Console.ReadLine();


        }

    }
}
