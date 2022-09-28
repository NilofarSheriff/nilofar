using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Library;

namespace _28september_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management Service");
            Console.WriteLine("Enter\n 1.Show \n2.Insert\n 3.Update\n 4.Delete\n");
            int opt= int.Parse(Console.ReadLine());
            Library library = new Library();
            switch (opt)
            {
                case 1:
                    {
                        library.show();
                        break;

                    }
                case 2:
                    {
                        BLL_LIb book = new BLL_LIb();
                        Console.WriteLine("Enter Book no to insert");
                        book.Bookno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Book Name :");
                        book.Name = Console.ReadLine();
                        Console.WriteLine("Cost:");
                        book.Cost = int.Parse(Console.ReadLine());
                        Console.WriteLine("Author :");
                        book.Author= Console.ReadLine();
                        Console.WriteLine("Category :");
                        book.Category = Console.ReadLine();
                        library.Insert(book);
                        Console.WriteLine("INSERTED SUCESSFULLY");
                        break;

                    }
                case 3:
                    {
                        BLL_LIb book = new BLL_LIb();
                        Console.WriteLine("Enter Book no to Update");
                        book.Bookno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Book Name :");
                        book.Name = Console.ReadLine();
                        Console.WriteLine("Cost:");
                        book.Cost = int.Parse(Console.ReadLine());
                        Console.WriteLine("Author :");
                        book.Author = Console.ReadLine();
                        Console.WriteLine("Category :");
                        book.Category = Console.ReadLine();
                        library.Update(book);
                        Console.WriteLine("UPDATED SUCESSFULLY");
                        break;

                    }
                case 4:
                    {
                        BLL_LIb book = new BLL_LIb();
                        Console.WriteLine("Enter Book no to Update");
                        book.Bookno = int.Parse(Console.ReadLine());
                        library.Delete(book);
                        Console.WriteLine("DELETED SUCESSFULLY");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid Number");
                        break;
                    }
            }
            
            
            Console.ReadLine();
        }
    }
}
