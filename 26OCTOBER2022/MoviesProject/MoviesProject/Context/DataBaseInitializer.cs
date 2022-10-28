using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MoviesProject.Models;

namespace MoviesProject.Context
{
    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            Movie M1 = new Movie
            {
                
                MovieName = "SitaRam",
                Language = "Tamil",
                RentalAmount = 900
            };
            Movie M2 = new Movie
            {
                MovieName = "Vikram",
                Language = "Tamil",
                RentalAmount = 2000
            };
            Movie M3 = new Movie
            {
                
                MovieName = "KGF2",
                Language = "Telugu",
                RentalAmount = 1500
            };
            Movie M4 = new Movie
            {
               
                MovieName = "Ponniyin Selvan",
                Language = "Malayalam",
                RentalAmount = 900
            };
            Movie M5 = new Movie
            {
               
                MovieName = "Harry Potter",
                Language = "Engilsh",
                RentalAmount = 1450
            };
            Movie M6 = new Movie
            {
                
                MovieName = "Barbie",
                Language = "English",
                RentalAmount = 300
            };

            User u1 = new User
            {
                Username = "nilofarsheriff@gmail.com",
                Password = "Nilo@123",
                Cat = Category.Platinum
            };
            User u2 = new User
            {
                Username = "meharsheriff@gmail.com",
                Password = "Mehar@123",
                Cat = Category.Gold
            };
            User u3 = new User
            {
                Username = "zamsheriff@gmail.com",
                Password = "zam@123",
                Cat = Category.Silver

            };
            User u4 = new User
            {
                Username = "mksheriff@gmail.com",
                Password = "Asif@123",
                Cat = Category.Platinum
            };
            context.Movies.Add(M1);
            context.Movies.Add(M2);
            context.Movies.Add(M3);
            context.Movies.Add(M4);
            context.Movies.Add(M5);
            context.Movies.Add(M6);
            context.Users.Add(u1);
            context.Users.Add(u2);
            context.Users.Add(u3);
            context.Users.Add(u4);
            context.SaveChanges();
        }

    }
}