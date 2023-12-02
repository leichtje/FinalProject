using FinalProject.Models;
using Microsoft.EntityFrameworkCore;


namespace FinalProject.Data
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options) :
            base(options)
        { }

        public DbSet<Sports> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder1)
        {

            modelBuilder1.Entity<Sports>().HasData(
                new Sports { SportID = 1, Name = "First Sport", FavoriteSport = "Football", FavoriteTeam = "Bearcats", FavoritePlayer = "Emory Jones" },
                new Sports { SportID = 2, Name = "Second Sport", FavoriteSport = "Soccer", FavoriteTeam = "US", FavoritePlayer = "Christian Pulisic" });
                
        }
    }
}
