using DAL_Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace _06OctoberAssignement_Adomvc_modelBinding.Models
{
    public class BookModel
    {
        [Required()]
        public int BookNo { get; set; }
        public string BookName { get; set; }

        public int Price { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KUI0108O;Initial Catalog=Library;Integrated Security=True");

        public void add(BookModel Book)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Book(Book_No,Book_Name,Author,Cost,Category)" +
                    " values(@bookid,@bookname,@author,@cost,@category)", con);
                cmd.Parameters.AddWithValue("@bookid", Book.BookNo);
                cmd.Parameters.AddWithValue("@bookname", Book.BookName);
                cmd.Parameters.AddWithValue("@author", Book.Author);
                cmd.Parameters.AddWithValue("@cost", Book.Price);
                cmd.Parameters.AddWithValue("@category", Book.Category);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateBook(BookModel Books)
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

        public List<BookModel> showBooks()
        {
            List<BookModel> BookList = new List<BookModel>();
            try
            {
                
                SqlCommand showcmd = new SqlCommand("Select * from Book", con);
                con.Open();
                SqlDataReader dr = showcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        BookModel Book = new BookModel();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BookList;
        }

        public void DeleteBook(BookModel Book)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[dbo].[Delete row Procedure]",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bookid", Book.BookNo);
                string cnstr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString.ToString();
                con.ConnectionString = cnstr;
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
        public BookModel search(int no)
        {
            BookModel Book = new BookModel();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Book where Book_No = @bookid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@bookid", no);
                SqlDataReader dr =   cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Book.BookNo = Convert.ToInt32(dr[0]);
                        Book.BookName = dr[1].ToString();
                        Book.Author = dr[2].ToString();
                        Book.Price = Convert.ToInt32(dr[3]);
                        Book.Category = dr[4].ToString();


                    }
                }

                con.Close();
                con.Dispose();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Book;
        }


    }
}

