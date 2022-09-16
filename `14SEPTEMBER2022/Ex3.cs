using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLib;
using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace _14September
{
    public class Ex3
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
            List<Movie> Seenmovies = new List<Movie>();
            foreach (Movie movie in movielist)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Language);
                Console.WriteLine("****************************************");
                Console.WriteLine("Have you seen that Movie \n Y or N");
                char opt = Convert.ToChar(Console.ReadLine());
                
                if (opt == 'Y')
                {
                    Seenmovies.Add(movie);
                    
                }
                
            }
            Movie[] seen = Seenmovies.ToArray();
            FileStream fs = new FileStream(@"seenmovie.json", FileMode.Create, FileAccess.Write);
            JavaScriptSerializer serial = new JavaScriptSerializer();
            StreamWriter sw = new StreamWriter(fs);StringBuilder sb = new StringBuilder();
                Console.WriteLine(sb);
                serial.Serialize(seen, sb);
                sw.Write(sb+"\n");
               

           
            sw.Flush();
            fs.Flush();
            sw.Close();
            fs.Close();
            sw.Dispose();
            fs.Dispose();
            Console.WriteLine("file added");
            Console.ReadLine();

            
        }

    }
}
