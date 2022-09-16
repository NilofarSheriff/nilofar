using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Users
    {

        public string Username { get; set; }
        public string Password { get; set; }

        private string _phno;

        public string PhoneNumber
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public DateTime AddedDate { get; set; }


        public void RegisterUser(Users user,List<Users> useslist )
        {
            Console.WriteLine("Enter Username");
            user.Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.Password=Console.ReadLine();
            user.AddedDate= DateTime.Now;
            Console.WriteLine("Enter Phone Number");
            user.PhoneNumber = Console.ReadLine();
            Users check=useslist.Find(X=>X.PhoneNumber==user.PhoneNumber);
            if (check == null)
            {
                useslist.Add(user);

            }
            else
            {
                Console.WriteLine("User already Registered");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have sucessfully Registered at the time "+user.AddedDate);
            Console.WriteLine("Username : "+user.Username);
            Console.WriteLine("Password : " + user.Password);
            Console.WriteLine("Phone : " + user.PhoneNumber);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Users u in useslist)
            {
                Console.WriteLine("Username : " + u.Username);
                Console.WriteLine("Password : " + u.Password);
                Console.WriteLine("Phone : " + u.PhoneNumber);
                Console.WriteLine("Registered Time : " + u.AddedDate);

            }


        }

        public void EditUserData(Users user, List<Users> useslist)
        {
            Console.WriteLine("Enter Phone Number");
            user.PhoneNumber = Console.ReadLine();
            Users check = useslist.Find(X => X.PhoneNumber == user.PhoneNumber);
            if (check != null)
            {
                Console.WriteLine("Enter Username");
                check.Username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                check.Password = Console.ReadLine();
                check.AddedDate = DateTime.Now;
                Console.WriteLine("Enter Phone Number");
                check.PhoneNumber = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User details edited sucessfully at "+check.AddedDate);
                Console.WriteLine("Username : " + check.Username);
                Console.WriteLine("Password : " + check.Password);
                Console.WriteLine("Phone : " + check.PhoneNumber);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (Users u in useslist)
                {
                    Console.WriteLine("Username : " + u.Username);
                    Console.WriteLine("Password : " + u.Password);
                    Console.WriteLine("Phone : " + u.PhoneNumber);
                    Console.WriteLine("Registered Time : "+u.AddedDate);

                }

            }
            else
            {
                Console.WriteLine("User not Found");
            }

        }
    }
}
