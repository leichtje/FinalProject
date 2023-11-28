using Microsoft.AspNetCore.Mvc;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MemberAPIController : Controller
	{
		IMemberService ctx;
		public MemberAPIController(IMemberService context)
		{
			ctx = context;
		}

		[HttpGet]
		[Route("api/getmembers")]
		public IActionResult Get()
		{
			return Ok(ctx.GetAllMembers());
		}

		[HttpGet("id")]
		public IActionResult Get(int id)
		{
			return Ok(ctx.GetMemberById(id));
		}

		[HttpPost]
		public IActionResult Post(Member p)
		{
			var result = ctx.AddMember(p);
			if (result == null)
			{
				return StatusCode(500, "A Member with this ID already exists");
			}
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

		[HttpPut]
		public IActionResult Put(Member p)
		{
			var result = ctx.UpdateMember(p);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

		[HttpDelete("id")]
		[Route("api/delete")]
		public IActionResult Delete(int id)
		{
			var product = ctx.GetMemberById(id);
			if (product == null)
			{
				return NotFound(id);
			}
			var result = ctx.RemoveMemberById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}
	}
}
