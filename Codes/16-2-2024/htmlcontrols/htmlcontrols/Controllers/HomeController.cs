using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace htmlcontrols.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.Colors = form["colors"];
            ViewBag.AcceptedTerms = form["acceptedTerms"] == "true";

            return View();
        }
    }
}
