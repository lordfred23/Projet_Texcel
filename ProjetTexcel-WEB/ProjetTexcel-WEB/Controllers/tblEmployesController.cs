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
    public class tblEmployesController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblEmployes
        public ActionResult Index()
        {
            var tblEmploye = db.tblEmploye.Include(t => t.tblRole);
            return View(tblEmploye.ToList());
        }

        // GET: tblEmployes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmploye tblEmploye = db.tblEmploye.Find(id);
            if (tblEmploye == null)
            {
                return HttpNotFound();
            }
            return View(tblEmploye);
        }

        // GET: tblEmployes/Create
        public ActionResult Create()
        {
            ViewBag.idRole = new SelectList(db.tblRole, "idRole", "nom");
            return View();
        }

        // POST: tblEmployes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "matricule,nom,prenom,dateNaissance,adresse,noTelephone,posteTelephone,noTelephoneMaison,idRole,tag")] tblEmploye tblEmploye)
        {
            if (ModelState.IsValid)
            {
                db.tblEmploye.Add(tblEmploye);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idRole = new SelectList(db.tblRole, "idRole", "nom", tblEmploye.idRole);
            return View(tblEmploye);
        }

        // GET: tblEmployes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmploye tblEmploye = db.tblEmploye.Find(id);
            if (tblEmploye == null)
            {
                return HttpNotFound();
            }
            ViewBag.idRole = new SelectList(db.tblRole, "idRole", "nom", tblEmploye.idRole);
            return View(tblEmploye);
        }

        // POST: tblEmployes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "matricule,nom,prenom,dateNaissance,adresse,noTelephone,posteTelephone,noTelephoneMaison,idRole,tag")] tblEmploye tblEmploye)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblEmploye).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idRole = new SelectList(db.tblRole, "idRole", "nom", tblEmploye.idRole);
            return View(tblEmploye);
        }

        // GET: tblEmployes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmploye tblEmploye = db.tblEmploye.Find(id);
            if (tblEmploye == null)
            {
                return HttpNotFound();
            }
            return View(tblEmploye);
        }

        // POST: tblEmployes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tblEmploye tblEmploye = db.tblEmploye.Find(id);
            db.tblEmploye.Remove(tblEmploye);
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
