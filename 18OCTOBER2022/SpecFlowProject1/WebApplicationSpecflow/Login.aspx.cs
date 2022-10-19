using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationSpecflow
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to my HomePage");

        }

        protected void sbt_Click(object sender, EventArgs e)
        {
            if(utext.Text=="Nilofar" && ptext.Text == "Nilofar@123")
            {
                Response.Write("Welcome");

            }
            else
            {
                Response.Write("Not welcoming You");
            }
        }
    }
}