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
    public class tblPlatformsController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblPlatforms
        public ActionResult Index(string search)
        {
            var tblPlatform = from s in db.tblPlatform.Include(t => t.tblSystemExploitation)
                              select s;
            if(!String.IsNullOrEmpty(search))
            {
                tblPlatform = tblPlatform.Where(s => s.tag.Contains(search));
            }
            return View(tblPlatform.ToList());
        }

        // GET: tblPlatforms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPlatform tblPlatform = db.tblPlatform.Find(id);
            if (tblPlatform == null)
            {
                return HttpNotFound();
            }
            return View(tblPlatform);
        }

        // GET: tblPlatforms/Create
        public ActionResult Create()
        {
            ViewBag.idSysExp = new SelectList(db.tblSystemExploitation, "idSysExp", "nom");
            return View();
        }

        // POST: tblPlatforms/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPlatform,nom,config,typePlatform,idSysExp,tag")] tblPlatform tblPlatform)
        {
            if (ModelState.IsValid)
            {
                db.tblPlatform.Add(tblPlatform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idSysExp = new SelectList(db.tblSystemExploitation, "idSysExp", "nom", tblPlatform.idSysExp);
            return View(tblPlatform);
        }

        // GET: tblPlatforms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPlatform tblPlatform = db.tblPlatform.Find(id);
            if (tblPlatform == null)
            {
                return HttpNotFound();
            }
            ViewBag.idSysExp = new SelectList(db.tblSystemExploitation, "idSysExp", "nom", tblPlatform.idSysExp);
            return View(tblPlatform);
        }

        // POST: tblPlatforms/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPlatform,nom,config,typePlatform,idSysExp,tag")] tblPlatform tblPlatform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPlatform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idSysExp = new SelectList(db.tblSystemExploitation, "idSysExp", "nom", tblPlatform.idSysExp);
            return View(tblPlatform);
        }

        // GET: tblPlatforms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPlatform tblPlatform = db.tblPlatform.Find(id);
            if (tblPlatform == null)
            {
                return HttpNotFound();
            }
            return View(tblPlatform);
        }

        // POST: tblPlatforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPlatform tblPlatform = db.tblPlatform.Find(id);
            db.tblPlatform.Remove(tblPlatform);
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
