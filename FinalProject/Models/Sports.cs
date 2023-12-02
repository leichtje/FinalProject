using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class Sports
	{
		[Key]
		public int SportID { get; set; }
		public string Name { get; set; }
		public string FavoriteSport { get; set; }
		public string FavoriteTeam { get; set; }
		public string FavoritePlayer { get; set; }

		public string GetDisplayText() => $"{SportID}  {Name}  {FavoriteSport} {FavoriteTeam} {FavoritePlayer} ";
	}
}
