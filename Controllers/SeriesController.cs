using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;

namespace SeriesMoviesProjectver2.Controllers
{
    public class SeriesController : Controller
    {
        // GET: Series
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index()
        {
            var series = smd.Tbl_Series.ToList();
            return View(series);
        }
    }
}