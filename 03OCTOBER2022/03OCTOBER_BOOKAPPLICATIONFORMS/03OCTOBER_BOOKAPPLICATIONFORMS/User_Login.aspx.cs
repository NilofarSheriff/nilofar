using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection.Emit;

namespace _03OCTOBER_BOOKAPPLICATIONFORMS
{
    public partial class User_Login : System.Web.UI.Page
    {
        

        SqlConnection c = new SqlConnection("Data Source=LAPTOP-KUI0108O;Initial Catalog=Library;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsbt_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Users(Userid,Password)values(@UserId,@Password)");
                cmd.Connection = c;
                c.Open();
                
                cmd.Parameters.AddWithValue("@UserId", usn.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", pwd.Text.ToString());
               
                SqlDataReader reader = cmd.ExecuteReader();
              
                if (reader.HasRows)
                {
                    Session["UserId"] = usn.Text.ToString();
                    Response.Write("Login Successful!");

                    reader.Close();
                    c.Close();

                    Response.Redirect("~/WebForm2.aspx");
                }
                else
                {
                    Response.Write("Invalid credentials");
                }

                reader.Close();

                c.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}