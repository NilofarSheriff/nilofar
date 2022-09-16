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
        public static int Stock;
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
        public DateTime exetime { get; set; }

        public DateTime Rented_time { get; set; }

        public DateTime Delivered_Time { get; set; }

        public double addtotal { get; set; }

        public int RentedDays { get; set; }

        public void RentCD(List<Movie> movielist, List<Movie> Moviestock,int n,Admin A)
        {
            double addtotal = 0;
            Console.WriteLine("Accept the Deal\n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("The movies available for you are");
            foreach (Movie items in movielist)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                items.Rented_time = new DateTime(2022, 9, 1);
                Console.Write(items.MovieName + " ");
                Console.Write(items.Language + " ");
                Console.Write(items.Genre + " ");
                Console.WriteLine(items.Price + " ");
                Console.Write(items.exetime + " ");
                Console.WriteLine();
            }
            if (no == 1)
            {

                
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the {0} movie you want to add", i);
                    string search1 = Console.ReadLine();
                    Movie Searchedmovies1 = movielist.Find(x => x.Genre == search1 || x.Language == search1 || x.MovieName
                == search1);
                    Moviestock.Add(Searchedmovies1);
                    movielist.Remove(Searchedmovies1);
                    Stock--;
                    Console.WriteLine("Enter how many days do you want for the Rent");
                    int days = int.Parse(Console.ReadLine());
                    Searchedmovies1.RentedDays=days;
                    double price = (days * (0.10 * Searchedmovies1.Price) * (0.18 * Searchedmovies1.Price));
                    addtotal += price;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Moviestock)
                {
                    Console.WriteLine("The movies you rented are");
                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {

                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
                A.Delivery(movielist, Moviestock);
            }
            else
            {
                Console.WriteLine("You cannot add these Movies");
            }
            
        }

        public void ReturnCD(List<Movie> movielist, List<Movie> Moviestock)
        {
            foreach (Movie items in Moviestock)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The movies you Rented are");
                Console.Write(items.MovieName + " ");
                Console.Write(items.Language + " ");
                Console.Write(items.Genre + " ");
                Console.Write(items.exetime + " ");
                Console.WriteLine();
            }
            char op = 'Y';
            while (op == 'Y')
            {
                Console.WriteLine("Enter the movie name you want to return or cancel");
                string mov = Console.ReadLine();
                Movie rem = Moviestock.Find(x => x.MovieName == mov);
                Moviestock.Remove(rem);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movie returned sucessfully");
                foreach (Movie items in Moviestock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The movies you Rented are");
                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();

                }
                movielist.Add(rem);
                Stock++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.WriteLine();
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
                Console.Write("Do you want to return another movie (Y/N) ? ");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    op = 'Y';
                }
                else
                {
                    break;
                }

            }



        }




    }

	public class Users
	{
		public string Username { get; set; }
		public string Password { get; set; }

		private string _phno;

		public string PhoneNumber
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

       public enum Badge
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5
        }
        public void SerachMovieByLANGandGenre(List<Movie> movielist)
        {
            Console.WriteLine("Genre :- \n 1. Family \n 2.Action \n 3.Children \n 4.Social awareness \n 5.Horror \n 6.Thriller" +
                "\n 7.History");
            Console.WriteLine("Languages :- \n 1.Tamil \n 2.English \n 3.Hindi \n 4.Telugu");
            Console.WriteLine("Enter the language or genre to search the movies");
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = movielist.FindAll(x => x.Genre == search || x.Language == search);
            if(Searchedmovies.Count > 0)
            {
                foreach (Movie movie in Searchedmovies)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(movie.MovieName);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Language);
                    Console.WriteLine("****************************************");
                }

            }
            else
            {
                Console.WriteLine("Movie can't be found..Check if there any typo..Or else we will add the movie " +
                    "soon as per your wish");
            }
            

        }

        public void Renting(List<Movie> movielist,Users Pass)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose the Badge you need \n Options:-\n 1.Silver - 2 Movies can be" +
                "Rented \n 2.Gold - 3 Movies can be Rented \n 3.Platinum - 5 Movies can be Rented \n "
                );
            //Users.Badge Userchoice = Users.Badge.Silver;
            int Userchoice = int.Parse(Console.ReadLine());
            switch (Userchoice)
            {
                case 1:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Silver, admin);
                        break;
                    }
                case 2:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Gold, admin);
                        break;
                    }
                case 3:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Platinum, admin);
                        break;
                    }
            }
        }
	}


	#region silver
	//public class SilverUser : Users
	//{
	//	private List<Movie> _moviestock;

	//	public new List<Movie> MovieStock
	//	{
	//		get { return _moviestock; }
	//		set
	//		{
	//			if (MovieStock.Count == 2) { _moviestock = value; }

	//		}
	//	}


	//}

	//public class GoldUser : SilverUser
	//{
	//	private List<Movie> _moviestock;

	//	public new List<Movie> MovieStock
	//	{
	//		get { return _moviestock; }
	//		set
	//		{
	//			if (MovieStock.Count == 3) { _moviestock = value; }

	//		}
	//	}

	//}

	//public class PlatinumUser : GoldUser
	//{
	//	private List<Movie> _moviestock;

	//	public new List<Movie> MovieStock
	//	{
	//		get { return _moviestock; }
	//		set
	//		{
	//			if (MovieStock.Count == 5) { _moviestock = value; }

	//		}
	//	}


	//} 
	#endregion



}


