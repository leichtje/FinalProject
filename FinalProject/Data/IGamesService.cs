using FinalProject.Models;

namespace FinalProject.Data
{
	public interface IGamesService
	{
		int? AddGame(Games p);
		List<Games> GetAllGames();
		Games GetGameById(int Id);
		int? RemoveGameById(int id);
		int? UpdateGame(Games p);
	}
}
