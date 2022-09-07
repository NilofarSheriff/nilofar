using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
    public delegate string concatdel(string a, string b);
    public class Ex6
    {
        public string concattwostr(string a, string b)
        { 
            string c = string.Concat(a, b);
            Console.WriteLine("The concated string is " + c);
            return c;
        }

    }
}
