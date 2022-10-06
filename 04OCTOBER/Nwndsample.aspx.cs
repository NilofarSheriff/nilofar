using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_Customer;

namespace _30sept_1_username_password
{
    public partial class Nwndsample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void select(object sender, EventArgs e)
        {
            Nwnd N = new Nwnd();
            N.Prodid = Convert.ToInt32(TextBox1.Text);
            HttpCookie cookie = new HttpCookie("Product details");
            cookie.Expires = DateTime.Now.AddMinutes(5);
            cookie.Secure = true;
            cookie.Values.Add("Product Id",N.Prodid.ToString());
            Response.Cookies.Add(cookie);
            Response.Write("Thanks for the input");

            
        }

        protected void add(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("Product Details");
            Nwnd c = new Nwnd();
            c.Prodid = Convert.ToInt32(cookie["Product Id"]);
            ListBox1.Items.Add(c.Prodid.ToString());
            Response.Write("Added succesfully");
        }
    }
}