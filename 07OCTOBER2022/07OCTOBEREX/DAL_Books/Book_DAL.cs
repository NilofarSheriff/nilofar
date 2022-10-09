using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Helper;

namespace DAL_Books
{
    public class Book
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KUI0108O;Initial Catalog=Library;Integrated Security=True");

        public void add(Book_Helper Book)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Book(Book_No,Book_Name,Author,Cost,Category)" +
                    " values(@bookid,@bookname,@author,@cost,@category)",con);
                cmd.Parameters.AddWithValue("@bookid", Book.BookNo);
                cmd.Parameters.AddWithValue("@bookname", Book.BookName);
                cmd.Parameters.AddWithValue("@author", Book.Author);
                cmd.Parameters.AddWithValue("@cost", Book.Price);
                cmd.Parameters.AddWithValue("@category", Book.Category);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateBook(Book_Helper Books)
        {
            try
            {

                SqlCommand updatecmd = new SqlCommand("[dbo].[UpdateBookDetails]", con);
                updatecmd.CommandType = System.Data.CommandType.StoredProcedure;
                updatecmd.Parameters.AddWithValue("@book_id", Books.BookNo);
                updatecmd.Parameters.AddWithValue("@book_name", Books.BookName);
                updatecmd.Parameters.AddWithValue("@Author", Books.Author);
                updatecmd.Parameters.AddWithValue("@cost", Books.Price);
                updatecmd.Parameters.AddWithValue("@category", Books.Category);
                con.Open();
                updatecmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void showBooks()
        {
            try
            {
                List<Book_Helper> BookList = new List<Book_Helper>();
                SqlCommand showcmd = new SqlCommand("Select * from Book",con);
                con.Open();
                SqlDataReader dr = showcmd.ExecuteReader();
               
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Book_Helper Book = new Book_Helper();
                        Book.BookNo = Convert.ToInt32(dr[0]);
                        Book.BookName = dr[1].ToString();
                        Book.Author = dr[2].ToString();
                        Book.Price = Convert.ToInt32(dr[3]);
                        Book.Category = dr[4].ToString();
                        BookList.Add(Book);

                    }   

                }
                else
                {
                    Console.WriteLine("No Books Available");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteBook(Book_Helper Book)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Book where Book_No  = @bookid", con);
                cmd.Parameters.AddWithValue("@bookid", Book.BookNo);
                Console.WriteLine("Deleted Sucessfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }


    }
}
