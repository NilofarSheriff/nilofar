using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Novel:Book,Ibooks
    {

        public int NoofPages
        {
            get { return noofpages; }
            set { noofpages = value; }
        }

        public new void InsertBook(int bookid, string bookName, int price)
        {

        }
        private int noofpages;

        


        public void InsertBook(int bookid, string bookName, int price,int pages)
        {
            this.BookId = bookid;
            this.BookName = bookName;
            this.Price = price;
            this.NoofPages = pages;

        }

        public void Insertbooks()
        {
            throw new NotImplementedException();
        }

        public void Insertbook(int bookid, int price)
        {
            throw new NotImplementedException();
        }
    }
}
