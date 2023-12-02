using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class Movies
	{
		[Key]
		public int MovieID { get; set; }
		public string Name { get; set; }
		public string MovieName { get; set; }
		public int  YearProduced  { get; set; }
		public string Director { get; set; }

		public string GetDisplayText() => $"{MovieID}  {Name}  {MovieName} {YearProduced} {Director} ";
	}
}
