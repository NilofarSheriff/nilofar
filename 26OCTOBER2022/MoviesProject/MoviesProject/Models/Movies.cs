using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesProject.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public string Language { get; set; }
        public decimal RentalAmount { get; set; }

        public virtual ICollection<User> Users { get; set; }


    }
    public class User
    {
        [Key]
        [EmailAddress]
        public string Username { get; set; }

        public string Password { get; set; }

        public Category Cat { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }


    }

    public enum Category
    {

        Platinum,
        Gold,
        Silver

    }

    
}