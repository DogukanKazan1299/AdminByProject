using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;

namespace SeriesMoviesProjectver2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index()
        {
            var login = smd.Tbl_Login.ToList();
            return View(login);
        }
    }
}