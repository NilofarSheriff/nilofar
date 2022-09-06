using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    interface Ibank
    {
        void PrintBalance(double amount);
        void CalculateInterest(double amount);
    }

    public class Saving : Ibank
    {
        public DateTime DDate = new DateTime(2001,10,27);
        public void PrintBalance(double amount)
        {
            
            Console.WriteLine("The available balance in your savings account is " + amount);
        }
        public void CalculateInterest(double amount)
        {

            amount = amount + (amount * 0.04);
            Console.WriteLine("The available balance in your savings account after adding interest is " + amount);
        }
    }

    public class Current : Ibank
    {
        public void PrintBalance(double amount)
        {
            Console.WriteLine("The available balance in your current account is " + amount);
        }
        public void CalculateInterest(double amount)
        {
            amount = amount + (amount * 0.02);
            Console.WriteLine("The available balance in your Current account after adding interest is " + amount);
        }

    }

}
