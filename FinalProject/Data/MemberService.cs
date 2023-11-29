using FinalProject.Models;

namespace FinalProject.Data
{
	public class MemberService:IMemberService
	{
		MemberContext ctx;
		public MemberService(MemberContext context)
		{
			ctx = context;
		}

		public int? AddMember(Member p)
		{
			var member = this.GetMemberById(p.MemberID);
			if (member != null)
			{
				return null;
			}
			ctx.Members.Add(p);
			return ctx.SaveChanges();
		}

		public List<Member> GetAllMembers()
		{//error
			return ctx.Members.ToList();
		}

		public Member GetMemberById(int Id)
		{
			return ctx.Members.FirstOrDefault(x => x.MemberID == Id);
		}

		public int? RemoveMemberById(int id)
		{
			var member = this.GetMemberById(id);
			if (member == null)
			{
				return null;
			}
			ctx.Members.Remove(member);
			return ctx.SaveChanges();
		}

		public int? UpdateMember(Member p)
		{
			ctx.Members.Update(p);
			return ctx.SaveChanges();
		}
	}
}
