using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL_Assign;
using Helper_Assign;

namespace _26septAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Libray System Management");
                Console.WriteLine("Enter number to perform actions");
                char c = 'y';
                while (c == 'y' || c == 'Y')
                {
                    Console.WriteLine("1.Insert\n2.Update\n3.Login and Borrow Book\n 4.Return Books\n5.Return");
                    Helper_Library actions = new Helper_Library();
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            {
                                BLL_Library Book = new BLL_Library();
                                Console.WriteLine("Enter Book no to insert");
                                Book.Book_No = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Book Name to insert");
                                Book.Book_Name = Console.ReadLine();
                                Console.WriteLine("Enter Author name to insert");
                                Book.Author = Console.ReadLine();
                                Console.WriteLine("Enter price of the Book");
                                Book.Cost = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the category");
                                Book.Category = Console.ReadLine();
                                actions.Addbook(Book);
                                Console.WriteLine("Inserted Sucessfully");
                                break;
                            }
                        case 2:
                            {
                                BLL_Library Book = new BLL_Library();
                                Console.WriteLine("Enter Book no to Update");
                                Book.Book_No = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Book Name to Update");
                                Book.Book_Name = Console.ReadLine();
                                Console.WriteLine("Enter Author name to Update");
                                Book.Author = Console.ReadLine();
                                Console.WriteLine("Enter Updated price of the Book");
                                Book.Cost = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the Updated category");
                                Book.Category = Console.ReadLine();
                                actions.UpdateBook(Book);
                                Console.WriteLine("Updated Sucessfully");
                                break;
                            }
                        case 3:
                            {
                                Users users = new Users();
                                Console.WriteLine("Enter Username");
                                users.Username = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                users.Password = Console.ReadLine();
                                actions.Login(users);

                                break;
                            }
                        case 4:
                            {
                                actions.ReturnBooks();
                                break;
                            }
                        case 5:
                            {
                                Environment.Exit(1);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Not a valid Option");
                                break;
                            }
                    }
                    Console.WriteLine("Do you want to perform other options (Y/N) ?");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if(ch=='y' || ch == 'Y')
                    {
                        c = 'Y';
                    }
                    else
                    {
                        break;

                    }

                }
                
                Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
        }
    }
}
