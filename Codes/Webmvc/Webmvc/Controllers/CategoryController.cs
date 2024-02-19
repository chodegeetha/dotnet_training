using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc.Models;

namespace Webmvc.Controllers
{
    public class CategoryController : Controller
    {
        UserContext cc = new UserContext();
        public ActionResult Index()
        {
            var  categoryitems=cc.Categories.ToList();
            return View(categoryitems);
        }
        public ActionResult Create(Category_Table category)
        {
            if(ModelState.IsValid)
            {
                cc.Categories.Add(category);
                int a=cc.SaveChanges();
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
        public ActionResult Edit(int Id)
        {
            var row=cc.Categories.Where (model=>model.CategoryId==Id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Category_Table category)
        {
            if(ModelState.IsValid)
            {
                cc.Entry(category).State=System.Data.Entity.EntityState.Modified;
                int a=cc.SaveChanges();
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

        public ActionResult Delete(int id)
        {
            var row = cc.Categories.Where(model => model.CategoryId == id).FirstOrDefault();
            cc.Categories.Remove(row);
            cc.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            var row = cc.Categories.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(row);
        }
    }
}
   