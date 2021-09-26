using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;
namespace SeriesMoviesProjectver2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index()
        {
            var books = smd.Tbl_Books.ToList();
            return View(books);
        }
    }
}