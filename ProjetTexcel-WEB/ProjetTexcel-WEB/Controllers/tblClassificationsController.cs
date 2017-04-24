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
    public class tblClassificationsController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblClassifications
        public ActionResult Index()
        {
            return View(db.tblClassification.ToList());
        }

        // GET: tblClassifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClassification tblClassification = db.tblClassification.Find(id);
            if (tblClassification == null)
            {
                return HttpNotFound();
            }
            return View(tblClassification);
        }

        // GET: tblClassifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblClassifications/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idClassification,nom,description,tag")] tblClassification tblClassification)
        {
            if (ModelState.IsValid)
            {
                db.tblClassification.Add(tblClassification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblClassification);
        }

        // GET: tblClassifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClassification tblClassification = db.tblClassification.Find(id);
            if (tblClassification == null)
            {
                return HttpNotFound();
            }
            return View(tblClassification);
        }

        // POST: tblClassifications/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idClassification,nom,description,tag")] tblClassification tblClassification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblClassification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblClassification);
        }

        // GET: tblClassifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClassification tblClassification = db.tblClassification.Find(id);
            if (tblClassification == null)
            {
                return HttpNotFound();
            }
            return View(tblClassification);
        }

        // POST: tblClassifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblClassification tblClassification = db.tblClassification.Find(id);
            db.tblClassification.Remove(tblClassification);
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
