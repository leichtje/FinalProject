namespace FinalProject.Models
{
	public class Games
	{
		public int MemberID { get; set; }
		public string Name { get; set; }
		public string FavoriteGame { get; set; }
		public string TypeOfGame { get; set; }
		public string Developer { get; set; }

		public string GetDisplayText() => $"{MemberID}  {Name}  {FavoriteGame} {TypeOfGame} {Developer} ";
	}
}
