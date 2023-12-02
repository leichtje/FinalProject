using FinalProject.Models;

namespace FinalProject.Data
{
    public interface IMoviesService
    {
        
		int? AddMovie(Movies p);
        List<Movies> GetAllMovies();
        Movies GetMovieById(int Id);
        int? RemoveMovieById(int id);
        int? UpdateMovie(Movies p);
    
    }
}

