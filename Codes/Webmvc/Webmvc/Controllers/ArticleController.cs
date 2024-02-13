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
        Articlecontext uc = new Articlecontext();
        public ActionResult Index()
        {
            var articles = uc.Articles.ToList();
            return View(articles);
        }
    }
}