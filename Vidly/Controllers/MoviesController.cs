using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //using viewdata
            //ViewData["Movie"] = movie;
            return View(viewmodel);
        }
        //[Route("movies/released/{year}/{month:regex(\\d[4}):range(1, 12)}")] //[vid-13]This is attribute based routing regex is to add ergualr expression range is to add the range of month. they are optional and many more constraints supproted by mvc framework
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}