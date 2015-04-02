namespace MvcMovieDatabase.Migrations
{
    using MvcMovieDatabase.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovieDatabase.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovieDatabase.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovieDatabase.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Harry Potter and the Sorcerer's Stone",
                    ReleaseDate = DateTime.Parse("2001-11-16"),
                    Genre = "Science Fiction & Fantasy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Harry Potter and the Half-Blood Prince",
                    ReleaseDate = DateTime.Parse("2009-07-15"),
                    Genre = "Science Fiction & Fantasy",
                    Price = 12.99M
                },

                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-05-04"),
                    Genre = "Action & Adventure",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Birdman",
                    ReleaseDate = DateTime.Parse("2014-10-17"),
                    Genre = "Comedy",
                    Price = 14.99M
                },

                new Movie
                {
                    Title = "The Theory of Everything",
                    ReleaseDate = DateTime.Parse("2014-11-07"),
                    Genre = "Drama",
                    Price = 14.99M
                }
                );  // End of Seed

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
