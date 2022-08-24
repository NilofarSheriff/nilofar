using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class strcopy
    {
        public static void Stringcopy(string a)
        {
            string b = string.Copy(a);
            Console.WriteLine("The string you given is " + a);
            Console.WriteLine("The string by copy method is " + b);

        }
    }
}
