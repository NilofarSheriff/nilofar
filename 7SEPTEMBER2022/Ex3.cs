using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
    public delegate void arithmeticdel(int a, int b);
    public class Ex3
    {
        public void add(int a, int b) 
        {
            int ans = a + b;
           
            Console.WriteLine("The addition of {0} and {1} is {2}",a,b,ans);
        }

        public void Sub(int a, int b)
        {
            int ans = a - b;
            Console.WriteLine("The addition of {0} and {1} is {2}", a, b, ans);
        }

        public void Mul(int a, int b)
        {
            int ans = a * b;
            Console.WriteLine("The addition of {0} and {1} is {2}", a, b, ans);
        }

    }
}
