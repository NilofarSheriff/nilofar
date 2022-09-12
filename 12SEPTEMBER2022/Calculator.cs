
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Calculator
    {
        public double power { get;}
       
       
        public double Number  { get; set; }

        public Calculator()
        {
            power = 3;

        }
       

        public void Cube(double num)
        {
           Number = num;
            double Result = Math.Pow(Number, power);
            Console.WriteLine("The cube of the number {0} is {1}",Number,Result);


        }

        public void Sqrt(double num)
        {
            Number = num;
            double Result = Math.Sqrt(Number);
            Console.WriteLine("The Square Root of the number {0} is {1}",Number, Result);
        }
    }
}
