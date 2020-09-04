using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMicro.Models
{
    public class Movie
    {
        public int ID {get; set;}
        public string Tttle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContent : DbContext
    {
        public DbSet<Movie> Movie { get; set; }

    }
}