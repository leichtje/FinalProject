using FinalProject.Models;

namespace FinalProject.Data
{
	public interface IMemberService
	{
		int? AddMember(Member p);
		List<Member> GetAllMembers();
		Member GetMemberById(int Id);
		int? RemoveMemberById(int id);
		int? UpdateMember(Member p);
	}
}
