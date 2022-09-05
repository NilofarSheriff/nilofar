using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Cart:Book
    {
		private int _customerid;

		public int CustomerId
		{
			get { return _customerid; }
			set { _customerid = value; }
		}
		public static int count;
        static public int cartcount;
        public void AddToCart(int CustomerId, Book[] books)
        {
				
			this.CustomerId = CustomerId;
            List<Book> booklist = new List<Book>();
			for (int i = 0; i < books.Length; i++)
			{
                count++;
                books[i] = new Book();
				Console.WriteLine("Enter the Book ID");
				books[i].BookId = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter the Book Name");
				books[i].BookName = Console.ReadLine();
				Console.WriteLine("Enter the Book price $ ");
				books[i].Price = int.Parse(Console.ReadLine());
				books[i].InsertBook(books[i].BookId, books[i].BookName, books[i].Price);
				booklist.Add(books[i]);
			}
        }

		private List<Book> _book;

		public List<Book> Book
		{
			get { return _book; }
			set { _book = value; }
		}


		public void DisplayDetails(Cart cart1, Book[] book1)
		{
			    Console.ForegroundColor = ConsoleColor.Green;
			    Console.WriteLine();
			    Console.WriteLine();
			    Console.WriteLine("*************************************");
			    Console.WriteLine("Customer ID : " + cart1.CustomerId);
			    for(int i = 0; i < book1.Length; i++)
			{
				Console.WriteLine();
                Console.WriteLine("Book ID : " + book1[i].BookId);
                Console.WriteLine("Book Name : " + book1[i].BookName);
                Console.WriteLine("Book Price : " + book1[i].Price);
                Console.WriteLine();
                Console.WriteLine();
               

            }
            



        }
       


    }
	public class carts : Bookabs
	{
		public override void Deletecart(Cart cart)
		{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write some advanced snippets to delete cart here after :) ");
        }
	}

}
