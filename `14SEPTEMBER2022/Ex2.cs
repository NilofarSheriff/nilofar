using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Xml.Serialization;

namespace _14September
{
    public class Ex2
    {
        static void Main(string[] args)
        {
            List<Movie> movielist = new List<Movie>();
            Movie movie1 = new Movie() { MovieName = "SitaRam", Language = "Tamil", Genre = "Family", Price = 60 };
            Movie movie2 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action", Price = 80 };
            Movie movie3 = new Movie() { MovieName = "KGF2", Language = "Telugu", Genre = "Action", Price = 60 };
            Movie movie4 = new Movie() { MovieName = "Jillunu oru Kaadhal", Language = "Tamil", Genre = "Family", Price = 50 };
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

            Console.WriteLine("Genre :- \n 1. Family \n 2.Action \n 3.Children \n 4.Social awareness \n 5.Horror \n 6.Thriller" +
                "\n 7.History");
            Console.WriteLine("Languages :- \n 1.Tamil \n 2.English \n 3.Hindi \n 4.Telugu");
            Console.WriteLine("Enter the language or genre to search the movies");
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = movielist.FindAll(x => x.Genre == search || x.Language == search);
            FileStream fs=new FileStream(@"Movie1.xml",FileMode.Create,FileAccess.Write);
            XmlSerializer serial = new XmlSerializer(typeof(List<Movie>));
            serial.Serialize(fs, Searchedmovies);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("file added");
            Console.ReadLine();

        }
}
}
