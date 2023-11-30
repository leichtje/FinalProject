using FinalProject.Models;

namespace FinalProject.Data
{
	public class GamesService:IGamesService
	{
		GamesContext ctx;
		public GamesService(GamesContext context)
		{
			ctx = context;
		}

		public int? AddGame(Games p)
		{
			var game = this.GetGameById(p.GameID);
			if (game != null)
			{
				return null;
			}
			ctx.Games.Add(p);
			return ctx.SaveChanges();
		}

		public List<Games> GetAllGames()
		{
			return ctx.Games.ToList();
		}

		public Games GetGameById(int Id)
		{
			return ctx.Games.FirstOrDefault(x => x.GameID == Id);
		}

		public int? RemoveGameById(int id)
		{
			var game = this.GetGameById(id);
			if (game == null)
			{
				return null;
			}
			ctx.Games.Remove(game);
			return ctx.SaveChanges();
		}

		public int? UpdateGame(Games p)
		{
			ctx.Games.Update(p);
			return ctx.SaveChanges();
		}
	}
}
