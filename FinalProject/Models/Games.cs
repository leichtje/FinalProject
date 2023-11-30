using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class Games
	{
		[Key]
		public int GameID { get; set; }
		public string Name { get; set; }
		public string FavoriteGame { get; set; }
		public string TypeOfGame { get; set; }
		public string Developer { get; set; }

		public string GetDisplayText() => $"{GameID}  {Name}  {FavoriteGame} {TypeOfGame} {Developer} ";
	}
}
