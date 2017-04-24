using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetTexcel_WEB;

namespace ProjetTexcel_WEB.Controllers
{
    public class tblGenresController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblGenres
        public ActionResult Index()
        {
            return View(db.tblGenre.ToList());
        }

        // GET: tblGenres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGenre tblGenre = db.tblGenre.Find(id);
            if (tblGenre == null)
            {
                return HttpNotFound();
            }
            return View(tblGenre);
        }

        // GET: tblGenres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblGenres/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idGenre,nom,description,tag")] tblGenre tblGenre)
        {
            if (ModelState.IsValid)
            {
                db.tblGenre.Add(tblGenre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblGenre);
        }

        // GET: tblGenres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGenre tblGenre = db.tblGenre.Find(id);
            if (tblGenre == null)
            {
                return HttpNotFound();
            }
            return View(tblGenre);
        }

        // POST: tblGenres/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idGenre,nom,description,tag")] tblGenre tblGenre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblGenre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblGenre);
        }

        // GET: tblGenres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGenre tblGenre = db.tblGenre.Find(id);
            if (tblGenre == null)
            {
                return HttpNotFound();
            }
            return View(tblGenre);
        }

        // POST: tblGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblGenre tblGenre = db.tblGenre.Find(id);
            db.tblGenre.Remove(tblGenre);
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
