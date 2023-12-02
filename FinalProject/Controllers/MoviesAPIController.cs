using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesAPIController : Controller
    {
        IMoviesService ctx;
        public MoviesAPIController(IMoviesService context)
        {
            ctx = context;
        }

        [HttpGet]
        [Route("api/getmovies")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllMovies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetMovieById(id));
        }

        [HttpPost]
        public IActionResult Post(Movies p)
        {
            var result = ctx.AddMovie(p);
            if (result == null)
            {
                return StatusCode(500, "A Movie with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Movies p)
        {
            var result = ctx.UpdateMovie(p);
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
            var game = ctx.GetMovieById(id);
            if (game == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveMovieById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
