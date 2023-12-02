using FinalProject.Models;

namespace FinalProject.Data
{
    public class MoviesService : IMoviesService
    {
        MoviesContext ctx;
        public MoviesService(MoviesContext context)
        {
            ctx = context;
        }

        public int? AddMovie(Movies p)
        {
            var movie = this.GetMovieById(p.MovieID);
            if (movie != null)
            {
                return null;
            }
            ctx.Movies.Add(p);
            return ctx.SaveChanges();
        }

        public List<Movies> GetAllMovies()
        {
            return ctx.Movies.ToList();
        }

        public Movies GetMovieById(int Id)
        {
            return ctx.Movies.FirstOrDefault(x => x.MovieID == Id);
        }

        public int? RemoveMovieById(int id)
        {
            var movie = this.GetMovieById(id);
            if (movie == null)
            {
                return null;
            }
            ctx.Movies.Remove(movie);
            return ctx.SaveChanges();
        }

        public int? UpdateMovie(Movies p)
        {
            ctx.Movies.Update(p);
            return ctx.SaveChanges();
        }
    }
}

