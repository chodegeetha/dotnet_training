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
        CategoryContext cc = new CategoryContext();
        public ActionResult Index()
        {
            var  categoryitems=cc.categories.ToList();
            return View(categoryitems);
        }
        public ActionResult Create(Category_Table category)
        {
            if(ModelState.IsValid)
            {
                cc.categories.Add(category);
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
            var row=cc.categories.Where (model=>model.CategoryId==Id).FirstOrDefault();
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
    }
}