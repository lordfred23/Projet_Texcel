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
    public class tblThemesController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblThemes
        public ActionResult Index()
        {
            return View(db.tblTheme.ToList());
        }

        // GET: tblThemes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTheme tblTheme = db.tblTheme.Find(id);
            if (tblTheme == null)
            {
                return HttpNotFound();
            }
            return View(tblTheme);
        }

        // GET: tblThemes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblThemes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTheme,nom,description,tag")] tblTheme tblTheme)
        {
            if (ModelState.IsValid)
            {
                db.tblTheme.Add(tblTheme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblTheme);
        }

        // GET: tblThemes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTheme tblTheme = db.tblTheme.Find(id);
            if (tblTheme == null)
            {
                return HttpNotFound();
            }
            return View(tblTheme);
        }

        // POST: tblThemes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTheme,nom,description,tag")] tblTheme tblTheme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblTheme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblTheme);
        }

        // GET: tblThemes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTheme tblTheme = db.tblTheme.Find(id);
            if (tblTheme == null)
            {
                return HttpNotFound();
            }
            return View(tblTheme);
        }

        // POST: tblThemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblTheme tblTheme = db.tblTheme.Find(id);
            db.tblTheme.Remove(tblTheme);
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
