using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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

            var movies = new List<Movie>();
            movies.Add(new Movie(1, "Shrek"));
            movies.Add(new Movie(2, "Wall-E"));

            var viewModel = new MoviesIndexViewModel
            {
                MovieList = movies
            };

            return View(viewModel);
        }

        public IActionResult Movie(int id)
        {
            var movies = new List<Movie>();
            movies.Add(new Movie(1, "Shrek"));
            movies.Add(new Movie(2, "Wall-E"));

            var movie = new Movie();
            foreach(var item in movies)
            {
                if(item.Id == id)
                {
                    movie = item;
                    break;
                }
            }

            return View(movie);
        }

        /*public IActionResult Random()
        {
            var movie = new Movie();

            movie.Id = 0;
            movie.Name = "Shrek";

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }*/

        /*public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }*/

        /*[HttpGet]
        [Route("movies/released/{{year:regex(\\d{4})}}/{{month:regex(\\d{2}):range(1, 12)}}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
           return Content(month + "/" + year);
        }*/
    }
}
