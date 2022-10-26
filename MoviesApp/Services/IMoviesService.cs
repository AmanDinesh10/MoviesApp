using System.Collections.Generic;
using MoviesApp.Models;

namespace MoviesApp.Services
{
    public interface IMoviesService
    {
         IEnumerable<Movie> GetAllMovies();
    }
}