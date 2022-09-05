using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
	public class Book
	{
		private int _bookid;

		public int BookId
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private string _bookname;

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}

		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public Book()
		{

		}

		public Book(int bookid, string Bookname)
		{
            this.BookId = bookid;
            this.BookName = Bookname;
            
        }

		public virtual void InsertBook(int bookid, string bookName, int price )
		{

            this.BookId = bookid;
            this.BookName = bookName;
            this.Price = price;

        }

        public void InsertBook(int bookid, string bookName, int price, string Author)
        {
            this.BookId = bookid;
            this.BookName = bookName;
            this.Price = price;
			this.Author = Author;

        }

        public void InsertBook(int bookid, string bookName)
        {
            this.BookId = bookid;
            this.BookName = bookName;
           
        }






    }

	public interface Ibooks
	{
		void Insertbooks();
		void Insertbook(int bookid, int price);

	

	}

    public abstract class Bookabs
    {
        public abstract void Deletecart(Cart cart);


    }
}
