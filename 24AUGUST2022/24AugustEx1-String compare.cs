using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class sampleclass
    {
        public static void Printstring()
        {
            Console.WriteLine("hELLO FROM THE LIBRARY");
        }

        public static void Stringcompare(string a, string b)
        {
            int len1 = a.Length;
            int len2 = b.Length;

            if(len1 != len2)
            {
                Console.WriteLine("Both are not equal as {0} is {1} amd {2} is {3}",a,len1,b,len2);
                
            }
            else
            {
                {
                    Console.WriteLine("Both are equal as {0} is {1} amd {2} is {3}", a, len1, b, len2);

                }

            }

            Console.ReadLine();

        }
    }
}
