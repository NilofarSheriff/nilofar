using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
    public delegate void findlength(string A);
    public class Ex1
    {
        public void lengthstring(string A)
        {
            int length = A.Length;
            Console.WriteLine("The length of the given string {0} is {1}",A,length);
        }

        public void Greetuser(string A)
        {
            Console.WriteLine("Hello " + A);
        }
    }
}
