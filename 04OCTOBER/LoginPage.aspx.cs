using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30sept_1_username_password
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Welcome to Login Page!!");


            }
            else
            {
               
                if (txtusn.Text == "Nilofar" && txtpwd.Text == "Nilofar@123")
                {
                    //Response.Write("Logged in sucessfully");
                    lbler0.Text = "Logged in Sucessfully";
                }

                else
                {
                    //Response.Write("Invalid Username or password");
                    lbler.Text = "Invalid Username or Password";
                }
            }
        }
    }
}