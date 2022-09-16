using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _14September
{
    internal class EX6
    {
        static void Main(string[] args)
        {
            List<Movie> movielist = new List<Movie>();
            Movie movie1 = new Movie() { MovieName = "SitaRam", Language = "Tamil", Genre = "Family", Price = 60, exetime = DateTime.Now };
            Movie movie2 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action", Price = 80, exetime = DateTime.Now };
            Movie movie3 = new Movie() { MovieName = "KGF2", Language = "Telugu", Genre = "Action", Price = 60, exetime = DateTime.Now };
            Movie movie4 = new Movie() { MovieName = "Jillunu oru Kaadhal", Language = "Tamil", Genre = "Family", Price = 50, exetime = DateTime.Now };
            Movie movie5 = new Movie() { MovieName = "Koodi vaalnthal kodi Nanmai", Language = "Tamil", Genre = "Social awareness", Price = 50, exetime = DateTime.Now };
            Movie movie6 = new Movie() { MovieName = "Barbie and the popstar", Language = "English", Genre = "Children", Price = 100, exetime = DateTime.Now };
            Movie movie7 = new Movie() { MovieName = "Singam 2", Language = "Tamil", Genre = "Family", Price = 160, exetime = DateTime.Now };
            Movie movie8 = new Movie() { MovieName = "Conjuring", Language = "English", Genre = "Horror", Price = 80, exetime = DateTime.Now };
            Movie movie9 = new Movie() { MovieName = "Psycho", Language = "Tamil", Genre = "Thriller", Price = 40, exetime = DateTime.Now };
            Movie movie10 = new Movie() { MovieName = "Barbie and 12 princess", Language = "English", Genre = "Children", Price = 80, exetime = DateTime.Now };
            Movie movie11 = new Movie() { MovieName = "Kalank", Language = "Hindi", Genre = "History", Price = 78, exetime = DateTime.Now };
            Movie movie12 = new Movie() { MovieName = "Pengal Naatin Kangal", Language = "Tamil", Genre = "Social awareness", Price = 54, exetime = DateTime.Now };

            movielist.Add(movie1); Movie.Stock++;
            movielist.Add(movie2); Movie.Stock++;
            movielist.Add(movie3); Movie.Stock++;
            movielist.Add(movie4); Movie.Stock++;
            movielist.Add(movie5); Movie.Stock++;
            movielist.Add(movie6); Movie.Stock++;
            movielist.Add(movie7); Movie.Stock++;
            movielist.Add(movie8); Movie.Stock++;
            movielist.Add(movie9); Movie.Stock++;
            movielist.Add(movie10); Movie.Stock++;
            movielist.Add(movie11); Movie.Stock++;
            movielist.Add(movie12); Movie.Stock++;

            
            FileStream fs = new FileStream(@"Rent amount details.bin",FileMode.Create,FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            movie9.Amount(movie2);
            formatter.Serialize(fs,movie2);
            FileStream fs1 = new FileStream(@"Rent amount details1.xml", FileMode.Create, FileAccess.Write);
            movie1.Amount(movie10);
            XmlSerializer serial = new XmlSerializer(typeof(Movie));
            serial.Serialize(fs1,movie10);
            Console.WriteLine("File Added");
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();


        }
    }
}
