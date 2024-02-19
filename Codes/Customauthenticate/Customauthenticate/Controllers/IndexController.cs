using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customauthenticate.fliter;

namespace Customauthenticate.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        [Geethaauthenticate]
        public ActionResult Index()
        {
            return View();
        }
    }
}