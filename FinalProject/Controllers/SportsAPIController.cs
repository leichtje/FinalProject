using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportsAPIController : Controller
    {
        ISportsService ctx;
        public SportsAPIController(ISportsService context)
        {
            ctx = context;
        }

        [HttpGet]
        [Route("api/getsports")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllSports());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetSportById(id));
        }

        [HttpPost]
        public IActionResult Post(Sports p)
        {
            var result = ctx.AddSport(p);
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
        public IActionResult Put(Sports p)
        {
            var result = ctx.UpdateSport(p);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var sport = ctx.GetSportById(id);
            if (sport == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveSportById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
