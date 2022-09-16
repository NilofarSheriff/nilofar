using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable()]
    public class CustomerUser
    {
		private string phno;

		public string PhoneNumber
		{
			get { return phno; }
			set { phno = value; }
		}

		public DateTime datecre { get; set; }
		public bool LoginStatus { get; private set; }

		public bool ValidateUser(CustomerUser user1)
		{
			Console.WriteLine("Enter UserName");
			string un = Console.ReadLine();
			Console.WriteLine("Enter Password");
			string pwd = Console.ReadLine();
			if ((un == user1.PhoneNumber)&&(pwd==(user1.PhoneNumber+"password")) )
			{
                return LoginStatus=true;
            }
			else
			{
				return LoginStatus=false;
			}
			

		}
	}

}
