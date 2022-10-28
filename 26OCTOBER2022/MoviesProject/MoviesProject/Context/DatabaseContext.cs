using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MoviesProject.Models;

namespace MoviesProject.Context
{
    
        public class DatabaseContext : DbContext
        {
        public DatabaseContext() : base("DefaultConnection") { }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
    
}