using MyBlogTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogTask1.Controllers
{
    public class HomeController : Controller
    {
        ArticleContext db = new ArticleContext();
        public ActionResult Index()
        {
            var articles = db.Articles;
            ViewBag.Articles = articles;
            return View();
        }

        public ActionResult Guestbook()
        {
            var reviews = db.Reviews;
            ViewBag.Reviews = reviews;
            return View();
        }

        public ActionResult Questionary()
        {
            return View();
        }

        [HttpPost]
        public string Guestbook(Review review)
        {
            review.Rdate = DateTime.Now;
            db.Reviews.Add(review);
            db.SaveChanges();
            return "Спасибо," + review.Rname + ", за отзыв!";
        }

    }
}