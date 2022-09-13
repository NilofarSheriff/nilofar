using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Admin
    {
		private List<Users> _userslist;

		public List<Users> UsersList
		{
			get { return _userslist; }
			set { _userslist = value; }
		}

		public void Adminapproval(List<Movie> movielist, int Stock,double addtotal,int n)
		{
            Console.WriteLine("Accept the Deal\n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            if (no == 1) {
                List<Movie> Moviestock = new List<Movie>();
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
                    double price = (days * (0.10 * Searchedmovies1.Price) * (0.18 * Searchedmovies1.Price));
                    addtotal += price;
                }
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Moviestock)
                {
                    Console.WriteLine("The movies you selected are");
                    Console.WriteLine(items.MovieName);
                    Console.WriteLine(items.Language);
                    Console.WriteLine(items.Genre);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
            }
            else
            {
                Console.WriteLine("You cannot add these Movies");
            }
           
        }

        public void AddUsers(List<Users> userlist)
        {
            Console.WriteLine("Do you want to add Users \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the number of Users to add");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Users user = new Users();
                    Console.WriteLine("Enter Username");
                    user.Username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    user.Password= Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    user.PhoneNumber = int.Parse(Console.ReadLine());
                    userlist.Add(user);

                }
                foreach (Users user in userlist)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine(user.Username);
                    Console.WriteLine(user.Password);
                    Console.WriteLine(user.PhoneNumber);
                    Console.WriteLine(user.AddedDate);
                    Console.WriteLine();
                }

            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }

        public void UpdateUsers(List<Users> userlist)
        {
            Console.WriteLine("Do you want Update a User \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Any one of the Users details to update");
                string search = Console.ReadLine();
                Users Name = userlist.Find(x => x.Username == search || x.Password == search);
                Console.WriteLine("Enter the Updated UserName");
                Name.Username = Console.ReadLine();
                Console.WriteLine("Enter the Updated Password");
                Name.Password = Console.ReadLine();
                Console.WriteLine("Enter the Updated PhoneNumber");
                Name.PhoneNumber = int.Parse(Console.ReadLine());
                foreach (Users user in userlist)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(user.Username);
                    Console.WriteLine(user.Password);
                    Console.WriteLine(user.PhoneNumber);
                    Console.WriteLine(user.AddedDate);
                    Console.WriteLine();
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }
        public void UpdateMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want Update a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Movie Name or Language or genre to update");
                string search = Console.ReadLine();
                Movie Name = movielist.Find(x => x.MovieName == search || x.Language==search || x.Genre == search);
                Console.WriteLine("Enter the Updated Movie Name");
                Name.MovieName=Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Language");
                Name.Language=Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Genre");
                Name.Genre=Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Price");
                Name.Price = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Movie movie in movielist)
                {
                    Console.WriteLine(movie.MovieName);
                    Console.WriteLine(movie.Language);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Price);
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }

        }

        public void AddMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want add a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the number of movies to add");
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    Movie movie = new Movie();
                    Console.WriteLine("Enter MovieName");
                    movie.MovieName= Console.ReadLine();
                    Console.WriteLine("Enter Language");
                    movie.Language= Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    movie.Genre= Console.ReadLine();
                    Console.WriteLine("Enter Movie price");
                    movie.Price=int.Parse(Console.ReadLine());
                    movielist.Add(movie);
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (Movie movies in movielist)
                    {
                        Console.WriteLine(movies.MovieName);
                        Console.WriteLine(movies.Language);
                        Console.WriteLine(movies.Genre);
                        Console.WriteLine(movies.Price);
                    }
                }
            }
            else if(opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }

        public void DeleteMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want Delete a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Movie Name or Language or genre to Delete");
                string search = Console.ReadLine();
                Movie Name = movielist.Find(x => x.MovieName == search || x.Language == search || x.Genre == search);
                movielist.Remove(Name);
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Movie movie in movielist)
                {
                    Console.WriteLine(movie.MovieName);
                    Console.WriteLine(movie.Language);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Price);
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }

        }
        public void DeleteUsers(List<Users> Userslist)
        {
            Console.WriteLine("Do you want Delete \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Users details");
                string search = Console.ReadLine();
                
                Users Name = Userslist.Find(x => x.Username == search || x.Password == search );
                Userslist.Remove(Name);
                Console.ForegroundColor=ConsoleColor.Red;
                foreach (Users user in Userslist)
                {
                    Console.WriteLine(user.Username);
                    Console.WriteLine(user.Password);
                    Console.WriteLine(user.PhoneNumber);
                    Console.WriteLine(user.AddedDate);
                    Console.WriteLine();
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }

        }
    }
}
