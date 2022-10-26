using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;
using MoviesApp.Services;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
       private readonly IMoviesService _inMemoryMovieData;

        public MoviesController(IMoviesService inMemoryMovieData)
        {
            _inMemoryMovieData = inMemoryMovieData;
        }

        public IActionResult Index()
        {
            var movies = _inMemoryMovieData.GetAllMovies();
            return View(movies);
        }
    }
}