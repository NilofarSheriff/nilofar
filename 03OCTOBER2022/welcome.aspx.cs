using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_Customer;

namespace _30sept_1_username_password
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("Customer Details");
            Customer c = new Customer();
            c.Firstname = cookie["FirstName"].ToString();
            c.Lastname = cookie["LastName"].ToString();

            welid.Text = "Welcome "+c.Firstname + " " + c.Lastname;
            
        }
    }
}