using FinalProject.Models;
using Microsoft.EntityFrameworkCore;


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
                new Movies { MovieID = 1, Name = "First Movie", MovieName = "Top Gun", YearProduced = 1986, Director = "Tony Scott" }
                );
        }
    }
}