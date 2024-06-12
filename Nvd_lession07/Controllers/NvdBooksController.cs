using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nvd_lession07.Models;

namespace Nvd_lession07.Controllers
{
    public class NvdBooksController : Controller
    {
        private NvdBookStore db = new NvdBookStore();

        // GET: NvdBooks
        public ActionResult Index()
        {
            return View(db.NvdBooks.ToList());
        }

        // GET: NvdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvdBook nvdBook = db.NvdBooks.Find(id);
            if (nvdBook == null)
            {
                return HttpNotFound();
            }
            return View(nvdBook);
        }

        // GET: NvdBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvdId,NvdBookId,NvdTitle,NvdAuthor,NvdYear,NvdPulisher,NvdPicture,NvdCategoryId")] NvdBook nvdBook)
        {
            if (ModelState.IsValid)
            {
                db.NvdBooks.Add(nvdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvdBook);
        }

        // GET: NvdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvdBook nvdBook = db.NvdBooks.Find(id);
            if (nvdBook == null)
            {
                return HttpNotFound();
            }
            return View(nvdBook);
        }

        // POST: NvdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvdId,NvdBookId,NvdTitle,NvdAuthor,NvdYear,NvdPulisher,NvdPicture,NvdCategoryId")] NvdBook nvdBook)
        {
            if (ModelState.IsValid)
            {
                db.NvdBooks.Add(nvdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvdBook);
        }

        // GET: NvdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvdBook nvdBook = db.NvdBooks.Find(id);
            if (nvdBook == null)
            {
                return HttpNotFound();
            }
            return View(nvdBook);
        }

        // POST: NvdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvdBook nvdBook = db.NvdBooks.Find(id);
            db.NvdBooks.Remove(nvdBook);
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
