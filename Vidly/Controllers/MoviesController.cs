using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public IActionResult Random()
        {
            var movie = new Movie();

            movie.Id = 0;
            movie.Name = "Shrek";

            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}
