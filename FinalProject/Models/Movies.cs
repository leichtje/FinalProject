using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class Movies
	{
		[Key]
		public int MemberID { get; set; }
		public string Name { get; set; }
		public string MovieName { get; set; }
		public int  YearProduced  { get; set; }
		public string Director { get; set; }

		public string GetDisplayText() => $"{MemberID}  {Name}  {MovieName} {YearProduced} {Director} ";
	}
}
