using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_Customer;

namespace _30sept_1_username_password
{
    public partial class Customer_signup : System.Web.UI.Page
    {
        

        protected void Select(object sender, EventArgs e)
        {
            txtdob.Text = dobin.SelectedDate.ToLongDateString();
        }

        protected void Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblcfn.Text = "Thanks for signing Up";
                Customer C = new Customer();
                C.Firstname = txtfn.Text;
                C.Lastname = txtln.Text;
                C.DOB = Convert.ToDateTime(txtdob.Text);
                C.City = txtcty.Text;
                C.State = txtste.Text;

                HttpCookie cookie = new HttpCookie("Customer Details");
                cookie.Expires = DateTime.Now.AddMinutes(5);
                cookie.Secure = true;
                cookie.Values.Add("FirstName", C.Firstname);
                cookie.Values.Add("LastName", C.Lastname);
                cookie.Values.Add("DOB", C.DOB.ToLongDateString());
                cookie.Values.Add("City", C.City);
                cookie.Values.Add("State", C.State);
                Response.Cookies.Add(cookie);

                Response.Redirect("~/welcome.aspx");
            }
            else
            {
                Response.Write("welcome to customer sign in page");
            }

        }
    }
}