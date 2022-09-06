using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace _6September
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region qn1
            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            //Clerk clerk = new Clerk();
            //clerk.Work();
            //Console.ReadLine(); 
            #endregion

            #region qn2
            //Saving saving = new Saving();
            //double amount = 1000000;
            //saving.PrintBalance(amount);
            //saving.CalculateInterest(amount);
            //Current currentaccount = new Current();
            //currentaccount.PrintBalance(amount);
            //currentaccount.CalculateInterest(amount); 
            #endregion

            Saving saving = new Saving();
            double amount = 1000000;
            int days = (DateTime.Now.Date - saving.DDate.Date).Days;
            Console.WriteLine("Your amount is{0} from {1} to {2} for the total days of{3}", 
                amount,saving.DDate,DateTime.Now,days);
            saving.PrintBalance(amount);
            saving.CalculateInterest(amount);
            saving.Withdraw(amount);
            saving.Deposit(amount);
            Current currentaccount = new Current();
            currentaccount.PrintBalance(amount);
            currentaccount.CalculateInterest(amount);
            currentaccount.Deposit(amount);
            currentaccount.Withdraw(amount);





            Console.ReadLine();
        }
    }
}
