using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GamesAPIController : Controller
	{
		IGamesService ctx;
		public GamesAPIController(IGamesService context)
		{
			ctx = context;
		}

		[HttpGet]
		[Route("api/getgames")]
		public IActionResult Get()
		{
			return Ok(ctx.GetAllGames());
		}

		[HttpGet("id")]
		public IActionResult Get(int id)
		{
			return Ok(ctx.GetGameById(id));
		}

		[HttpPost]
		public IActionResult Post(Games p)
		{
			var result = ctx.AddGame(p);
			if (result == null)
			{
				return StatusCode(500, "A Person with this ID already exists");
			}
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

		[HttpPut]
		public IActionResult Put(Games p)
		{
			var result = ctx.UpdateGame(p);
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
			var game = ctx.GetGameById(id);
			if (game == null)
			{
				return NotFound(id);
			}
			var result = ctx.RemoveGameById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}
	}
}
