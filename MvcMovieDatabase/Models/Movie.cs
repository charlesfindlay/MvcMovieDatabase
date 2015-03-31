using System;
using System.Data.Entity;

namespace MvcMovieDatabase.Models
{
    public class Movie  // This class movie maps to a table named movie in the database
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } // Generic DbSet contains movie
    }

}