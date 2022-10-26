using System.Collections.Generic;
using System.Linq;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Services
{
    public class MovieService : IMoviesService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _context.Movies.ToList();
            return movies;
        }
    }
}