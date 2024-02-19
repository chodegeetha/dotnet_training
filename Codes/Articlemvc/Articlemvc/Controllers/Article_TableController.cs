using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Articlemvc.Models;

namespace Articlemvc.Controllers
{
    public class Article_TableController : Controller
    {
        private WordVoyagerEntities db = new WordVoyagerEntities();

        // GET: Article_Table
        public ActionResult Index()
        {
            return View(db.Article_Table.ToList());
        }

        // GET: Article_Table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article_Table article_Table = db.Article_Table.Find(id);
            if (article_Table == null)
            {
                return HttpNotFound();
            }
            return View(article_Table);
        }

        // GET: Article_Table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article_Table/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArticleId,Title,Content,PublishedDate,LastModifiedDate,AuthorId,CategoryId")] Article_Table article_Table)
        {
            if (ModelState.IsValid)
            {
                db.Article_Table.Add(article_Table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article_Table);
        }

        // GET: Article_Table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article_Table article_Table = db.Article_Table.Find(id);
            if (article_Table == null)
            {
                return HttpNotFound();
            }
            return View(article_Table);
        }

        // POST: Article_Table/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArticleId,Title,Content,PublishedDate,LastModifiedDate,AuthorId,CategoryId")] Article_Table article_Table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article_Table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article_Table);
        }

        // GET: Article_Table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article_Table article_Table = db.Article_Table.Find(id);
            if (article_Table == null)
            {
                return HttpNotFound();
            }
            return View(article_Table);
        }

        // POST: Article_Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article_Table article_Table = db.Article_Table.Find(id);
            db.Article_Table.Remove(article_Table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
