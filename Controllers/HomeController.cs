using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using MovieCollection.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMovieRepo _repo;
        private MovieContext _con { get; set; }

        public HomeController(ILogger<HomeController> logger, IMovieRepo repo, MovieContext con)
        {
            _logger = logger;
            _repo = repo;
            _con = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult newMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult newMovie(Movie movie)
        {
            _con.Movies.Add(movie);
            _con.SaveChanges();

            return View("confirmation");
        }
        public IActionResult myMovies()
        {
            var results = (from m in _con.Movies
                           select new MovieViewModel()
                           {
                               ID = m.ID.ToString(),
                               Category = m.Category,
                               Title = m.Title,
                               Year = m.Year,
                               Director = m.Director,
                               Rating = m.Rating,
                               Edited = m.Edited,
                               Lent = m.Lent,
                               Notes = m.Notes,
                           }).ToList();

            ViewBag.results = results;

            return View();
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
