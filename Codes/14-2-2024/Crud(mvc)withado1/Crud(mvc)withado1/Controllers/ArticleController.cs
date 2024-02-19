using System.Linq;
using System;
using System.Web.Mvc;
using Crud_mvc_withado1.Models;
using log4net;
using System.Collections.Generic;

namespace Crud_mvc_withado1.Controllers
{
    public class ArticleController : Controller
    {

     // private static readonly ILog log = LogManager.GetLogger(typeof(ArticleController));


        [OutputCache(Duration = 3600)]
        [Filter.LogExceptionFilter]
        [Authorize]

        public ActionResult Index()
        {
            var list = Articledb.GetAllArticles();
            //throw new Exception("Error Occured!");
            return View(list);
        }
        /*try
        {
            throw new Exception("DB NIT AVAILABLE!");
            return View(list);
        }
        catch (Exception ee)
        {
           // log.Info("hello");
           log.debug(ee.message);

        }*/



        [OutputCache(Duration = 260)]
            public ActionResult Details(int id)
            {
                var row = Articledb.GetArticleById(id);
                return View(row.First());
            }


           
            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
           
            [ValidateAntiForgeryToken]
            public ActionResult Create(string title, string content, DateTime publishedDate, DateTime lastModifiedDate)
            {
                if (Articledb.InsertArticle(title, content, publishedDate, lastModifiedDate))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Error");
                }
            }



            public ActionResult Edit(int id)
            {
                var row = Articledb.GetArticleById(id);
                return View(row.First());
            }

            [HttpPost]

            [ValidateAntiForgeryToken]
            public ActionResult Edit(int? articleId, string title, string content, DateTime publishedDate, DateTime lastModifiedDate)
            {
                if (articleId == null)
                {
                    // Handle the case where articleId is not provided
                    return View("Error");
                }

                if (Articledb.UpdateArticle(articleId.Value, title, content, publishedDate, lastModifiedDate))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Error");
                }
            }


            [Authorize]
            public ActionResult Delete(int id)
            {
                var row = Articledb.GetArticleById(id);
                return View(row.First());
            }

            [HttpPost]
            [HandleError]
            public ActionResult Delete(int id, Articlemodel article)
            {
                try
                {
                    bool b = Articledb.DeleteArticle(id);
                    if (b)
                    {
                        return RedirectToAction("Index");
                    }
                    return View();
                }
                catch
                {
                    return View();
                }
            }
        }


    }
