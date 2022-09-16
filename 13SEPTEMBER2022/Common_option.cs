using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Commonoption
    {
        public void changePassword(List<Users> userlist, Users usere)
        {

            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            Users user = userlist.Find(x => usere.Password == pass);
            if (user != null)
            {
                DateTime AddedDate = usere.AddedDate;
                DateTime now = DateTime.Now;
                if ((now.Month - AddedDate.Month) >= 1)
                {
                    Console.WriteLine("Change your Password");
                    Console.WriteLine("Enter New Password");
                    usere.Password = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("After changing Password");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(usere.Username);
                    Console.WriteLine(usere.Password);
                    Console.WriteLine(usere.PhoneNumber);
                }
                else
                {
                    Console.WriteLine("Thank you!! for visiting");

                }


            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }



        }
        public void userpro(List<Users> userslist)
        {
            Console.WriteLine("Enter UserName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            Users sel1 = userslist.Find(x => x.Username == name);

            if (sel1 != null)
            {
                Users sel2 = userslist.Find(x => sel1.Password == pass);
                if (sel2 != null)
                {
                    Console.WriteLine("UserName : " + sel1.Username);
                    Console.WriteLine("Password: " + sel1.Password);
                    Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                    Console.WriteLine("Added date : " + sel1.AddedDate);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Update Details\n Yes or No");
                    string op = Console.ReadLine();
                    if (op == "Yes")
                    {
                        Console.WriteLine("Enter the Updated UserName");
                        sel1.Username = Console.ReadLine();
                        Console.WriteLine("Enter the Updated Password");
                        sel1.Password = Console.ReadLine();
                        Console.WriteLine("Enter the Updated PhoneNumber");
                        sel1.PhoneNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Updated Details are as follows");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("UserName : " + sel1.Username);
                        Console.WriteLine("Password: " + sel1.Password);
                        Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                        Console.WriteLine("Added date : " + sel1.AddedDate);
                        Console.WriteLine();

                    }
                    else if (op == "No")
                    {

                        Console.WriteLine("UserName : " + sel1.Username);
                        Console.WriteLine("Password: " + sel1.Password);
                        Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                        Console.WriteLine("Added date : " + sel1.AddedDate);
                        Console.WriteLine();
                    }



                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Invalid UserName");
            }
        }
    }
}
