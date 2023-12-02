using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
	public class MemberContext:DbContext
	{
		public MemberContext(DbContextOptions<MemberContext> options) :
			base(options) { }
		public DbSet<Member> Members { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Member>().HasData(
				new Member { MemberID = 1, Name = "America",  Birthday = "07/04/1776", CollegeProgram = "Winning", YearInProgram = "Graduated"},
				new Member { MemberID = 2, Name = "Jonathon", Birthday = "11/21/1999", CollegeProgram = "IT", YearInProgram = "Sophomore" },
				new Member { MemberID = 3, Name = "Joel", Birthday = "04/16/2004", CollegeProgram = "IT", YearInProgram = "Sophomore" }
				);
		}
	}
}

