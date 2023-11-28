namespace FinalProject.Models
{
	public class Hobby
	{
		public int MemberID { get; set; }
		public string Name { get; set; }
		public string FavoriteThingToDo { get; set; }
		public int  YearsExperience  { get; set; }
		public string Expensive { get; set; }

		public string GetDisplayText() => $"{MemberID}  {Name}  {FavoriteThingToDo} {YearsExperience} {Expensive} ";
	}
}
