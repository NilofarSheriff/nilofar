using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16_username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Remember the following two things:\n 1.Your first name will be your Username \n 2.Your last name will be your password");
            Console.WriteLine("*****************************************");
            Console.Write("Username : ");
            string uname=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password: ");
            string password=Console.ReadLine();
            if ((uname == fname) && (lname == password))
            {
                Console.WriteLine("\n \n ***Welcome to my App***");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
                
            }
            Console.ReadLine();


        }
    }
}
