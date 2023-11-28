namespace FinalProject.Models
{
	public class Sports
	{
		public int MemberID { get; set; }
		public string Name { get; set; }
		public string FavoriteSport { get; set; }
		public string FavoriteTeam { get; set; }
		public string FavoritePlayer { get; set; }

		public string GetDisplayText() => $"{MemberID}  {Name}  {FavoriteSport} {FavoriteTeam} {FavoritePlayer} ";
	}
}
