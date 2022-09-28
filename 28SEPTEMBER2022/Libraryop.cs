using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_CB;
using System.Data.Entity;


namespace BLL_Library
{
    public class Library
    {
        public void show()
        {
            LibraryEntities Context = new LibraryEntities();
            List<Book> library = Context.Books.ToList();
            foreach (Book book in library)
            {
                Console.WriteLine(book.Book_No);
                Console.WriteLine(book.Book_Name);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Cost);
                Console.WriteLine(book.Category);
                Console.WriteLine();
            }

        }

        public void Insert(BLL_LIb Book2)
        {
            LibraryEntities context = new LibraryEntities();
            Book book1 = new Book();
            book1.Book_No = Book2.Bookno;
            book1.Book_Name = Book2.Name;
            book1.Author = Book2.Author;
            book1.Cost = Book2.Cost;
            book1.Category = Book2.Category;
            context.Books.Add(book1);
            context.SaveChanges();
            

        }

        public void Update(BLL_LIb b)
        {
            LibraryEntities context = new LibraryEntities();
            List<Book> books = context.Books.ToList();
            Book fnd = books.Find(x => x.Book_No == b.Bookno);
            fnd.Book_No = b.Bookno;
            fnd.Book_Name = b.Name;
            fnd.Author = b.Author;
            fnd.Cost = b.Cost;
            fnd.Category = b.Category;
            context.SaveChanges();
        }

        public void Delete(BLL_LIb D)
        {
            LibraryEntities context = new LibraryEntities();
            List<Book> books = context.Books.ToList();
            Book fnd = books.Find(x => x.Book_No == D.Bookno);
            context.Books.Remove(fnd);
            context.SaveChanges();

        }
        

    }
}
