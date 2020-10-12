using System;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    { 
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieResultView(MovieResultViewModel model)
        {
            // var movieViewModel = new MovieViewModel();

            return View(model);
        }
    }
}
