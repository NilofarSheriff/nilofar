using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Movie
    {
		private string _movieName;

		public string MovieName
		{
			get { return _movieName; }
			set { _movieName = value; }
		}

		private string _genre;

		public string Genre
		{
			get { return _genre; }
			set { _genre = value; }
		}

		private string _language;

		public string Language
		{
			get { return _language; }
			set { _language = value; }
		}
		public int Price { get; set; }




	}

	public class Users
	{
		public string Username { get; set; }
		public string Password { get; set; }

		private int _phno;

		public int PhoneNumber
		{
			get { return _phno; }
			set { _phno = value; }
		}
		public DateTime AddedDate { get; set; }

		private List<Movie> _moviestock;

		public List<Movie> MovieStock
		{
			get { return _moviestock; }
			set {
				if (MovieStock.Count >= 5) { _moviestock = value; }
				else
				{
					Console.WriteLine("No more rental is allowed if the limit is reached");
				}
			}
		}

		public void Display()
		{
			if (MovieStock.Count == 2)
				Console.WriteLine("Hello User you have a Silver Badge");
			if (MovieStock.Count == 3)
				Console.WriteLine("Hello User you have a Gold Badge");
			if (MovieStock.Count == 5)
				Console.WriteLine("Hello User you have a Platinum Badge");


		}
	}


        public class SilverUser :Users
		{
			private List<Movie> _moviestock;

			public new List<Movie> MovieStock
			{
				get { return _moviestock; }
				set {
                    if (MovieStock.Count == 2) { _moviestock = value; }
                    
                }
			}
			

		}

        public class GoldUser : SilverUser
        {
            private List<Movie> _moviestock;

            public new List<Movie> MovieStock
            {
                get { return _moviestock; }
                set
                {
                    if (MovieStock.Count == 3) { _moviestock = value; }

                }
            }

        }

        public class PlatinumUser : GoldUser
        {
            private List<Movie> _moviestock;

            public new List<Movie> MovieStock
            {
                get { return _moviestock; }
                set
                {
                    if (MovieStock.Count == 5) { _moviestock = value; }

                }
            }


        }



    }


