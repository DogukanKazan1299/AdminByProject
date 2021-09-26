using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesMoviesProjectver2.Models.Entity;

namespace SeriesMoviesProjectver2.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        SeriesMoviesDatabaseEntities smd = new SeriesMoviesDatabaseEntities();
        public ActionResult Index()
        {
            var comment = smd.Tbl_Comment.ToList();
            return View(comment);
        }
    }
}