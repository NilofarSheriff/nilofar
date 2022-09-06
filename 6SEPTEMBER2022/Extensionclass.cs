using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    static public class Extensionclass
    {
        static public void Withdraw(this Saving S,double amount)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
           
            Console.WriteLine("Enter the amount to withdraw");
            int withdraw = int.Parse(Console.ReadLine());
            if(withdraw < amount)
            {
                amount = amount - withdraw;
                Console.WriteLine("The {0} withdraw sucessfully",withdraw);
                Console.WriteLine("The Remaining balance is " + amount);

            }
            else
            {
                Console.WriteLine("Card Declined");
            }
         
        }

        static public void Withdraw(this Current C, double amount)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the amount to withdraw");
            int withdraw = int.Parse(Console.ReadLine());
            if (withdraw < amount)
            {
                amount = amount - withdraw;
                Console.WriteLine("The {0} withdraw sucessfully", withdraw);
                Console.WriteLine("The Remaining balance is " + amount);

            }
            else
            {
                Console.WriteLine("Card Declined");
            }

        }
        static public void Deposit(this Saving S, double amount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the amount to Deposit");
            int deposit = int.Parse(Console.ReadLine());
            amount = amount+deposit;
            Console.WriteLine("The {0} withdraw sucessfully", deposit);
            Console.WriteLine("The total balance is " + amount);
        }

        static public void Deposit(this Current C, double amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the amount to Deposit");
            int deposit = int.Parse(Console.ReadLine());
            amount = amount + deposit;
            Console.WriteLine("The {0} withdraw sucessfully", deposit);
            Console.WriteLine("The total balance is " + amount);
        }

    }
}
