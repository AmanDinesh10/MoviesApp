using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;
using MoviesApp.Services;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
       private readonly IMoviesService _movieService;

        public MoviesController(IMoviesService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _movieService.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}