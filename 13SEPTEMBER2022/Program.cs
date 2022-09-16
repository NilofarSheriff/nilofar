using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule;


namespace _13September
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Users> userslist = new List<Users>();
            Users user1 = new Users() { Username = "Mehar", Password = "Abcde",AddedDate= new DateTime(2022,02,2) };
            Users user2 = new Users() { Username = "Nilofar", Password = "123456", AddedDate = new DateTime(2022, 03, 12) };
            Users user3 = new Users() { Username = "Zamruth", Password = "23345", AddedDate = new DateTime(2022, 01, 23) };
            Users user4 = new Users() { Username = "Sheriff", Password = "34568", AddedDate = new DateTime(2022, 02, 14) };
            Users user5 = new Users() { Username = "Asif", Password = "12344", AddedDate = new DateTime(2022, 1, 2) };
            Users user6 = new Users() { Username = "Varshini", Password = "R1233", AddedDate = new DateTime(2022, 2, 2) };
            Users user7 = new Users() { Username = "Israth", Password = "QWERTY", AddedDate = new DateTime(2022, 02, 2) };
            userslist.Add(user1);
            userslist.Add(user2);
            userslist.Add(user3);
            userslist.Add(user4);
            userslist.Add(user5);
            userslist.Add(user6);
            userslist.Add(user7);
            
            

            List<Movie> movielist = new List<Movie>();
            Movie movie1 = new Movie() {MovieName="SitaRam",Language="Tamil",Genre="Family",Price=60};
            Movie movie2 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action" ,Price = 80 };
            Movie movie3 = new Movie() { MovieName = "KGF2", Language = "Telugu", Genre = "Action", Price = 60 };
            Movie movie4= new Movie() { MovieName = "Jillunu oru Kaadhal", Language = "Tamil", Genre = "Family", Price = 50 };
            Movie movie5 = new Movie() { MovieName = "Koodi vaalnthal kodi Nanmai", Language = "Tamil", Genre = "Social awareness", Price = 50 };
            Movie movie6 = new Movie() { MovieName = "Barbie and the popstar", Language = "English", Genre = "Children", Price = 100 };
            Movie movie7 = new Movie() { MovieName = "Singam 2", Language = "Tamil", Genre = "Family", Price = 160 };
            Movie movie8 = new Movie() { MovieName = "Conjuring", Language = "English", Genre = "Horror", Price = 80 };
            Movie movie9 = new Movie() { MovieName = "Psycho", Language = "Tamil", Genre = "Thriller", Price = 40 };
            Movie movie10 = new Movie() { MovieName = "Barbie and 12 princess", Language = "English", Genre = "Children", Price = 80 };
            Movie movie11 = new Movie() { MovieName = "Kalank", Language = "Hindi", Genre = "History", Price = 78 };
            Movie movie12 = new Movie() { MovieName = "Pengal Naatin Kangal", Language = "Tamil", Genre = "Social awareness", Price = 54 };
            
            movielist.Add(movie1);
            movielist.Add(movie2);  
            movielist.Add(movie3);
            movielist.Add(movie4);
            movielist.Add(movie5);
            movielist.Add(movie6);
            movielist.Add(movie7);  
            movielist.Add(movie8);
            movielist.Add(movie9);
            movielist.Add(movie10);
            movielist.Add(movie11);
            movielist.Add(movie12);
            Movie.Stock = movielist.Count();
            Console.WriteLine("1.User Module 2.Admin Module 3.Common Options");
            int option = int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    {
                        Console.WriteLine("Enter Username and Password");
                        Action<string, string> Login = (string username, string password) =>
                        {
                            Users Name = userslist.Find(x => x.Username == username);
                            Users Pass = userslist.Find(x => Name.Password == password);
                            if (Name != null)
                            {
                                if (Pass != null)
                                {
                                    Console.WriteLine("Logged In " + Name.Username + "!!");
                                    Console.WriteLine("The Top Rated Movies Rented By others are :");
                                    foreach (Movie Movies in movielist)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine(Movies.MovieName);
                                        Console.WriteLine(Movies.Language);
                                        Console.WriteLine(Movies.Genre);
                                        Console.WriteLine("______________________");
                                    }
                                    char c = 'Y';
                                    while (c == 'Y') {
                                        Console.WriteLine("Select 1 to search Movies \n select 2 to rent movies");
                                        int sel = int.Parse(Console.ReadLine());
                                        switch (sel)
                                        {
                                            case 1:
                                                user1.SerachMovieByLANGandGenre(movielist);
                                                break;
                                            case 2:
                                                user2.Renting(movielist, Pass);
                                                break;
                                            default:
                                                Environment.Exit(1);
                                                break;
                                        }
                                        Console.WriteLine("Do you want to continue (Y/N)");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        if (ch == 'Y' || ch == 'y')
                                        {
                                            c = 'Y';
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    

                                }
                                else
                                {
                                    Console.WriteLine("Password is incorrect");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No user found");
                            }

                        };
                        Login(Console.ReadLine(), Console.ReadLine()); ;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Admin Operation to perform");
                        Console.WriteLine("1.Users Modification 2.Movie Modifications");
                        int Opt = int.Parse(Console.ReadLine());
                        Admin admin = new Admin();
                        switch (Opt)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter 1 for Add User \n 2 for Update User \n 3 for delete User");
                                    int n = int.Parse(Console.ReadLine());
                                    if (n == 1)
                                    {
                                        admin.AddUsers(userslist);
                                    }
                                    else if (n == 2)
                                    {
                                        admin.UpdateUsers(userslist);
                                    }
                                    else if (n == 3)
                                    {
                                       admin.DeleteUsers(userslist);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Enter 1 for Add Movie \n 2 for Update Movie \n 3 for delete Movie");
                                    int n = int.Parse(Console.ReadLine());
                                    if (n == 1)
                                    {
                                        admin.AddMovies(movielist);
                                    }
                                    else if (n == 2)
                                    {
                                        admin.UpdateMovies(movielist);
                                    }
                                    else if (n == 3)
                                    {
                                        admin.DeleteMovies(movielist);
                                    }
                                    break;
                                }
                           
                        }
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Enter the action to perform");
                        Console.WriteLine("Enter\n 1 for Change Password \n 2 User option to change and view profile");
                        Commonoption commonopt = new Commonoption();
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Enter Username");
                            string name = Console.ReadLine();
                            Users sel1 = userslist.Find(x => x.Username == name);
                            
                             if(sel1 != null)
                                {
                                    
                                    commonopt.changePassword(userslist,sel1);
                                
                                }
                            
                           
                           
                           
                        }
                        else if (n == 2)
                        {
                            commonopt.userpro(userslist);
                            

                        }
                        break;
                    }
                    
            }
            
            
                





            Console.ReadLine();
        }
    }

    
}
