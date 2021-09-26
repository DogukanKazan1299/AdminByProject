using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;

namespace SeriesMoviesProjectver2.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index()
        {
            var games = smd.Tbl_Games.ToList();
            return View(games);
        }
    }
}