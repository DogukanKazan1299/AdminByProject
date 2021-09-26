using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace SeriesMoviesProjectver2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index(int values=1)
        {
            var movies = smd.Tbl_Movies.ToList().ToPagedList(values,5);
            return View(movies);
        }
    }
}