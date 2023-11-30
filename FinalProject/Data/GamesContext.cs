using FinalProject.Models;
using Microsoft.EntityFrameworkCore;


namespace FinalProject.Data
{
	public class GamesContext:DbContext
	{
		public GamesContext(DbContextOptions<GamesContext> options) :
			base(options){ }

		public DbSet<Games> Games { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder1)
		{
			
			modelBuilder1.Entity<Games>().HasData(
				new Games { GameID = 1, Name = "America", FavoriteGame = "Call of Duty", TypeOfGame = "Shooter", Developer = "Activision" }
				);
		}
	}
}
