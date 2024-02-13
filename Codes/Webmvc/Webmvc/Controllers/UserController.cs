using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc.Models;
using System.Data;
using System.Data.Entity;
using EntityState = System.Data.Entity.EntityState;

namespace Webmvc.Controllers
{
    public class UserController : Controller
    {
        UserContext uc = new UserContext();
        public ActionResult Index()
        {
            var Users = uc.Users.ToList();
            return View(Users);
        }
        public ActionResult Create(User_Table user)
        {
            if (ModelState.IsValid)
            {
                uc.Users.Add(user);
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
        public ActionResult Edit(int id)
        {
            var row = uc.Users.Where(model => model.UserId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(User_Table user)
        {
            if (ModelState.IsValid)
            {
                uc.Entry(user).State = EntityState.Modified;
                int a= uc.SaveChanges();
                if (a > 0)
                {
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage("Something went wrong!");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row = uc.Users.Where(model => model.UserId == id).FirstOrDefault();
            uc.Users.Remove(row);
            uc.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            var row = uc.Users.Where(model => model.UserId == id).FirstOrDefault();
            return View(row);
        }
    }
}
                   

               
