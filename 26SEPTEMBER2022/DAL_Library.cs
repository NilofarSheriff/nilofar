using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BLL_Assign;
namespace DAL_Assign
{
    public class DAL_Library
    {
        /// <summary>
        /// Insert into employee table the data for firstname,lastname,title,birthdate
        /// Empid is identity field so not inserting
        /// </summary>
        /// <param name="Book"></param>
        /// 

        
        public void InsertBook(BLL_Library Books)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
                SqlCommand insertcmd = new SqlCommand("insert into Book(Book_No,Book_Name,Author,Cost,Category) values(@book_no,@book_name,@Author,@Cost,@Category)", con);



                insertcmd.Parameters.AddWithValue("@book_no", Books.Book_No);
                insertcmd.Parameters.AddWithValue("@book_name", Books.Book_Name);
                insertcmd.Parameters.AddWithValue("@Author", Books.Author);
                insertcmd.Parameters.AddWithValue("@Cost", Books.Cost);
                insertcmd.Parameters.AddWithValue("@Category", Books.Category);
                con.Open();
                insertcmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void UpdateBook(BLL_Library Books)
        {
            try {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
                SqlCommand updatecmd = new SqlCommand("[dbo].[UpdateBookDetails]", con);
                updatecmd.CommandType = System.Data.CommandType.StoredProcedure;
                updatecmd.Parameters.AddWithValue("@book_id", Books.Book_No);
                updatecmd.Parameters.AddWithValue("@book_name", Books.Book_Name);
                updatecmd.Parameters.AddWithValue("@Author", Books.Author);
                updatecmd.Parameters.AddWithValue("@cost", Books.Cost);
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
        public void Users(Users user,BLL_Library Books)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
            SqlCommand Logincmd = new SqlCommand("[dbo].sp_UserLogin", con);
            Logincmd.CommandType = System.Data.CommandType.StoredProcedure;
            Logincmd.Parameters.AddWithValue("@user_id", user.Username);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@user_id";
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Input;

            Logincmd.Parameters.AddWithValue("@password", user.Password);
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@password";
            p2.SqlDbType = System.Data.SqlDbType.VarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Input;

            Logincmd.Parameters.AddWithValue("@book_no", Books.Book_No);
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@book_no";
            p3.SqlDbType = System.Data.SqlDbType.Int;
            p3.Size = 5;
            p3.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@book_name", Books.Book_Name);
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@book_name";
            p4.SqlDbType = System.Data.SqlDbType.VarChar;
            p4.Size = 30;
            p4.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@Author", Books.Author);
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Author";
            p5.SqlDbType = System.Data.SqlDbType.VarChar;
            p5.Size = 30;
            p5.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@cost", Books.Cost);
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@cost";
            p6.SqlDbType = System.Data.SqlDbType.Int;
            p6.Size = 5;
            p6.Direction = System.Data.ParameterDirection.Output;

            Logincmd.Parameters.AddWithValue("@category", Books.Category);
            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@category";
            p7.SqlDbType = System.Data.SqlDbType.VarChar;
            p7.Size = 10;
            p7.Direction = System.Data.ParameterDirection.Output;




        }

        public List<BLL_Library> booklist(Users user)
        {
            List<BLL_Library> Booklist = new List<BLL_Library>();
            try {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
                SqlCommand cmdlist = new SqlCommand("select * from  [dbo].fn_Booklist(@user_id,@password)", con);
                cmdlist.Parameters.AddWithValue("@user_id", user.Username);
                cmdlist.Parameters.AddWithValue("@password", user.Password);
                con.Open();
                SqlDataReader dr = cmdlist.ExecuteReader();
               
                if (dr.HasRows)
                {
                    Console.WriteLine("Logged in sucessfully");
                    Console.WriteLine("The List of Books are here");
                    while (dr.Read())
                    {

                        BLL_Library Books = new BLL_Library();
                        Books.Book_No = Convert.ToInt32(dr[0]);
                        Books.Book_Name = Convert.ToString(dr[1]);
                        Books.Author = Convert.ToString(dr[2]);
                        Books.Cost = Convert.ToInt32(dr[3]);
                        Books.Category = Convert.ToString(dr[4]);
                        Booklist.Add(Books);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                }
                con.Close();
                con.Dispose();
                
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message); 
            }
            return Booklist;
        }

        public void BorrowBooks()
        {
            Issue issue1 = new Issue();
            try {
                Console.WriteLine("Enter the Book_Id to Borrrow");
                BLL_Library books = new BLL_Library();
                books.Book_No = Convert.ToInt32(Console.ReadLine());
                issue1.Book_No = books.Book_No;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
                SqlCommand Issuecommand = new SqlCommand("Insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date," +
                    "Return_Date,Comments) Values(@id,@bookno,@memberid,@isedate,@redate,@comments)", con);
                Console.WriteLine("Enter Library Issue Id");
                issue1.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Member Id");
                issue1.Member_Id = Convert.ToInt32(Console.ReadLine());
                issue1.Issue_Date = DateTime.Now;
                issue1.Return_Date = issue1.Issue_Date.AddDays(15);
                issue1.Comments = "Borrowed";
                Issuecommand.Parameters.AddWithValue("@id", issue1.Lib_Issue_Id);
                Issuecommand.Parameters.AddWithValue("@bookno", issue1.Book_No);
                Issuecommand.Parameters.AddWithValue("@memberid", issue1.Member_Id);
                Issuecommand.Parameters.AddWithValue("@isedate", issue1.Issue_Date);
                Issuecommand.Parameters.AddWithValue("@redate", issue1.Return_Date);
                Issuecommand.Parameters.AddWithValue("@comments", issue1.Comments);
                con.Open();
                Issuecommand.ExecuteNonQuery();
                con.Close();
                con.Dispose();
               
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void returnbook()
        {
            try
            {
                Issue issue1 = new Issue();
                Console.WriteLine("Enter the Issue Id");
                issue1.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Libcon"].ConnectionString);
                SqlCommand returnb = new SqlCommand("[dbo].[change_return_statuss]", con);
                returnb.CommandType = System.Data.CommandType.StoredProcedure;
                returnb.Parameters.AddWithValue("@id", issue1.Lib_Issue_Id);
                con.Open();
                returnb.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                


            }
            catch(Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
        }



    }
}
