using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Random()
        {
            var movie = new Movie();

            movie.Id = 0;
            movie.Name = "Shrek";

            return View(movie);
        }
    }
}
