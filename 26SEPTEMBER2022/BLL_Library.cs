using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BLL_Assign
{
    public class BLL_Library
    {
		private int _bookid;

		public int Book_No
		{
			get { return _bookid; }
			set { 
				if(value > 0)
				{
                    _bookid = value;

                }
				else
				{

					Console.WriteLine("Invalid BookNo");
				}
				 }

		}
		private string book_name;

		public string Book_Name
		{
			get { return book_name; }
			set {
				if (string.IsNullOrEmpty(value)||value.Length>30)
				{
					Console.WriteLine("Invalid Book Name");
					
				}
				else
				{
                    book_name = value;
                }
			}
		}

		public string Author { get; set; }
		public int Cost { get; set; }
		public string Category { get; set; }
	}

	public class Users
	{
		private string user_name;

		public string Username
		{
            get { return user_name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 10)
                {
                    Console.WriteLine("Invalid  UserName");

                }
                else
                {
                    user_name = value;
                }
            }
        }

		private string _password;

		public string Password
		{
			get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 20)
                {
                    Console.WriteLine("Invalid  Password");

                }
                else
                {
                    _password = value;
                }
            }
        }

	}


	 public class Issue
	{
		public int Lib_Issue_Id { get; set; }
		public int Book_No { get; set; }

		
		private int _memberid;

		public int Member_Id
		{
			get { return _memberid; }
			set {if(value > 0 && value < 7)
				{
                    _memberid = value;

				}
				else
				{
					Console.WriteLine("Invalid Member Id");
				}
				 }
		}


		public DateTime Issue_Date { get; set; }

		

		private DateTime _Return_Date;

		public DateTime Return_Date
        {
			get { return _Return_Date; }
			set { _Return_Date = value; }
                
		}

		public string Comments { get; set; }
	}
}
