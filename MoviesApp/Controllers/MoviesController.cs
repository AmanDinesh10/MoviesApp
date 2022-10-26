using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;
using MoviesApp.Services;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
       private readonly InMemoryMovieData inMemoryMovieData;

        public MoviesController()
        {
            inMemoryMovieData = new InMemoryMovieData();
        }

        public IActionResult Index()
        {
            var movies = inMemoryMovieData.GetMovies();
            return View(movies);
        }
    }
}