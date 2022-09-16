using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;

namespace _14September
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            List<Users> userslist = new List<Users>();
            Users user1 = new Users() { Username = "Mehar", Password = "Abcde",PhoneNumber="123456789", AddedDate = new DateTime(2022, 02, 2) };
            Users user2 = new Users() { Username = "Nilofar", Password = "123456", PhoneNumber = "349558789", AddedDate = new DateTime(2022, 03, 12) };
            Users user3 = new Users() { Username = "Zamruth", Password = "23345", PhoneNumber = "1234567878", AddedDate = new DateTime(2022, 01, 23) };
            Users user4 = new Users() { Username = "Sheriff", Password = "34568", PhoneNumber = "931123456", AddedDate = new DateTime(2022, 02, 14) };
            Users user5 = new Users() { Username = "Asif", Password = "12344", PhoneNumber = "874123456", AddedDate = new DateTime(2022, 1, 2) };
            Users user6 = new Users() { Username = "Varshini", Password = "R1233", PhoneNumber = "7865123456", AddedDate = new DateTime(2022, 2, 2) };
            Users user7 = new Users() { Username = "Israth", Password = "QWERTY", PhoneNumber = "68945123456", AddedDate = new DateTime(2022, 02, 2) };
            userslist.Add(user1);
            userslist.Add(user2);
            userslist.Add(user3);
            userslist.Add(user4);
            userslist.Add(user5);
            userslist.Add(user6);
            userslist.Add(user7);

            char ch = 'Y';
            while (ch == 'Y')
            {
                Console.WriteLine("1 for Register\n 2 for Edit Details");
                int op = int.Parse(Console.ReadLine()); 
                switch (op)
                {
                    case 1:
                        {
                            Users newuser = new Users();
                            newuser.RegisterUser(newuser, userslist);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<Users>));
                            serial.Serialize(fs, userslist);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                    case 2:
                        {
                            Users newuser = new Users();
                            newuser.EditUserData(newuser, userslist);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<Users>));
                            serial.Serialize(fs, userslist);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                }
                Console.WriteLine("Do you want to continue ? (y/n)");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    ch = 'Y';
                }
                else
                {
                    break;
                }

            }
            
            Console.ReadLine();
        }
    }
}
