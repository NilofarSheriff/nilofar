using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class CalculatorFunctions
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber+SecondNumber;
        }

        public int Sub()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Divison()
        {
            return FirstNumber / SecondNumber;
        }

        public int Sqrt()
        {
            return (int)Math.Sqrt(FirstNumber);
        }
    }
}
