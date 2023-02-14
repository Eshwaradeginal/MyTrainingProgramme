using MoviesWebApp.MovieComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWebApp.Controllers
{
    public class MovieController : Controller
    {
        //private MovieRepo repo = new MovieRepo();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public  string  MovieIndex()=>"Movie List";
        public ActionResult AddMovies()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addmovies(MovieEntity movie)
        {
            var repo = new MovieRepo();
            repo.AddMovie(movie);
            return RedirectToAction("AddMovies");
        }


        [HttpGet]
        public ActionResult viewAllMovies()
        {
            var repo = new MovieRepo();
            var data =repo.fGetAllMovies();
            return View(data);
        }
        [HttpGet]
        
        public ActionResult vGetAllCasting()
        {
            var repo = new MovieRepo();
            var data = repo.fGetAllCasting();
            return View(data);
        }
        [HttpGet]
        public ActionResult vGetAllDirector()
        {
            var repo = new MovieRepo();
            var data = repo.fGetAllDirector();
            return View(data);
        }
        [HttpGet]
        public ActionResult vGetAllActor()
        {
            var repo = new MovieRepo();
            var data = repo.fGetAllActor();
            return View(data);
        }


    }
}