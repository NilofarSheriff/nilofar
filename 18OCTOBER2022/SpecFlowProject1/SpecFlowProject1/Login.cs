using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class LoginPage
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        public string Login()
        {
            string Welcome;
            if(Username == "Nilofar" && Password == "Nilofar@123")
            {
                Welcome = "Login Sucessful";
            }
            else
            {
                Welcome = "Invalid Credentials";
            }
            return Welcome;
        }
    }
}
