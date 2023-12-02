using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Xml.Linq;


namespace FinalProject.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) :
            base(options)
        { }

        public DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder1)
        {

            modelBuilder1.Entity<Movies>().HasData(
                new Movies { MovieID = 1, Name = "First Movie", MovieName = "Top Gun", YearProduced = 1986, Director = "Tony Scott" },
                new Movies { MovieID = 2, Name = "Second Movie", MovieName = "Top Gun: Maverick", YearProduced = 2022, Director = "Tony Scott" }
                );
        }
    }
}