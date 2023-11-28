namespace FinalProject.Models
{
	public class Member
	{
		public int MemberID { get; set; }
		public string Name { get; set; }
		public string Birthday { get; set; }
		public string CollegeProgram { get; set; }
		public string YearInProgram { get; set; }

		public string GetDisplayText() => $"{MemberID}  {Name}  {Birthday} {CollegeProgram} {YearInProgram} ";
	}
}
