using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
    public delegate void strfirst(string str);
    public class Ex7
    {

        public void strcap(string a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Empty String");
            }
            else if (a.Length == 1)
            {
                Console.WriteLine(char.ToUpper(a[0]));
            }
            else
            {
                Console.WriteLine(char.ToUpper(a[0]) + a.Substring(1));
            }

        }
    }
}
