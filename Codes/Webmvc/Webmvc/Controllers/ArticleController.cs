using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc.Models;

namespace Webmvc.Controllers
{
    public class ArticleController : Controller
    {
        UserContext uc = new UserContext();
        public ActionResult Index()
        {
            var articles = uc.Articles.ToList();
            return View(articles);
        }
        public ActionResult Create(Article_Table Article)
        {
            if (ModelState.IsValid)
            {
                uc.Articles.Add(Article);
                int a = uc.SaveChanges();
                if (a > 0)
                {
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage("went wrong");
                }
            }

            return View();
        }

    }
}