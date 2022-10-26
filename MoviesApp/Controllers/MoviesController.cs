using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> movies = new List<Movie>()
        {
            new Movie {Id = 1, Name = "Iron Man", Description = "Action Movie", Rating = 8 },
            new Movie {Id = 2, Name = "Bat Man", Description = "Action Movie", Rating = 8 },
            new Movie {Id = 3, Name = "KGF 2", Description = "Action Movie", Rating = 8 },
            new Movie {Id = 4, Name = "Lover", Description = "Romantic Movie", Rating = 8 }
        };
        
        public IActionResult Index()
        {
            return View(movies);
        }
    }
}