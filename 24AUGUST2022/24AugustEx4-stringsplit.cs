using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class stringsplit
    {
        public static void Strsplit(string a)
        {
            string [] sep = { "#" };
            int cnt = 2;
            string[] result= a.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
            




        }
    }
}
