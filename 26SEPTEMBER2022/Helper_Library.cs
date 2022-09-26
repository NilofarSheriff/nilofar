using BLL_Assign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Assign;

namespace Helper_Assign
{
    public class Helper_Library
    {
        public void Addbook(BLL_Library Book)
        {
            DAL_Library Library = new DAL_Library();
            Library.InsertBook(Book);

        }

        public void UpdateBook(BLL_Library Book)
        {
            DAL_Library Library = new DAL_Library();
            Library.UpdateBook(Book);

        }

        public void Login(Users User)
        {
            DAL_Library Library = new DAL_Library();
            List<BLL_Library> BookL=Library.booklist(User);
            
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (BLL_Library LibraryL in BookL)
                {
                    Console.WriteLine("Book_No: " + LibraryL.Book_No);
                    Console.WriteLine("Book_Name: " + LibraryL.Book_Name);
                    Console.WriteLine("Book Author: " + LibraryL.Author);
                    Console.WriteLine("Book_Price: " + LibraryL.Cost);
                    Console.WriteLine("Book_Category: " + LibraryL.Category);
                    Console.WriteLine();
                }
            Console.WriteLine("Do you want to Borrow Books (Y/N)? ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='Y' || ch == 'y')
            {
                Library.BorrowBooks();
                Console.WriteLine("Book issued Now");
            }

        }

        public void ReturnBooks()
        {
            DAL_Library Library = new DAL_Library();
            Library.returnbook();
            Console.WriteLine("Book returned Sucessfully");

        }

    }
}
