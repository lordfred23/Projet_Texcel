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
    public class tblJeusController : Controller
    {
        private bdTexelFredAlexEntities db = new bdTexelFredAlexEntities();

        // GET: tblJeus
        public ActionResult Index()
        {
            var tblJeu = db.tblJeu.Include(t => t.tblClassification).Include(t => t.tblGenre).Include(t => t.tblPlatform).Include(t => t.tblTheme);
            return View(tblJeu.ToList());
        }

        // GET: tblJeus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJeu tblJeu = db.tblJeu.Find(id);
            if (tblJeu == null)
            {
                return HttpNotFound();
            }
            return View(tblJeu);
        }

        // GET: tblJeus/Create
        public ActionResult Create()
        {
            ViewBag.idClassification = new SelectList(db.tblClassification, "idClassification", "nom");
            ViewBag.idGenre = new SelectList(db.tblGenre, "idGenre", "nom");
            ViewBag.idPlatform = new SelectList(db.tblPlatform, "idPlatform", "nom");
            ViewBag.idTheme = new SelectList(db.tblTheme, "idTheme", "nom");
            return View();
        }

        // POST: tblJeus/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idJeu,developpeur,description,minimalConfig,idClassification,idGenre,idTheme,idPlatform,nom,tag")] tblJeu tblJeu)
        {
            if (ModelState.IsValid)
            {
                db.tblJeu.Add(tblJeu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idClassification = new SelectList(db.tblClassification, "idClassification", "nom", tblJeu.idClassification);
            ViewBag.idGenre = new SelectList(db.tblGenre, "idGenre", "nom", tblJeu.idGenre);
            ViewBag.idPlatform = new SelectList(db.tblPlatform, "idPlatform", "nom", tblJeu.idPlatform);
            ViewBag.idTheme = new SelectList(db.tblTheme, "idTheme", "nom", tblJeu.idTheme);
            return View(tblJeu);
        }

        // GET: tblJeus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJeu tblJeu = db.tblJeu.Find(id);
            if (tblJeu == null)
            {
                return HttpNotFound();
            }
            ViewBag.idClassification = new SelectList(db.tblClassification, "idClassification", "nom", tblJeu.idClassification);
            ViewBag.idGenre = new SelectList(db.tblGenre, "idGenre", "nom", tblJeu.idGenre);
            ViewBag.idPlatform = new SelectList(db.tblPlatform, "idPlatform", "nom", tblJeu.idPlatform);
            ViewBag.idTheme = new SelectList(db.tblTheme, "idTheme", "nom", tblJeu.idTheme);
            return View(tblJeu);
        }

        // POST: tblJeus/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idJeu,developpeur,description,minimalConfig,idClassification,idGenre,idTheme,idPlatform,nom,tag")] tblJeu tblJeu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblJeu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idClassification = new SelectList(db.tblClassification, "idClassification", "nom", tblJeu.idClassification);
            ViewBag.idGenre = new SelectList(db.tblGenre, "idGenre", "nom", tblJeu.idGenre);
            ViewBag.idPlatform = new SelectList(db.tblPlatform, "idPlatform", "nom", tblJeu.idPlatform);
            ViewBag.idTheme = new SelectList(db.tblTheme, "idTheme", "nom", tblJeu.idTheme);
            return View(tblJeu);
        }

        // GET: tblJeus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJeu tblJeu = db.tblJeu.Find(id);
            if (tblJeu == null)
            {
                return HttpNotFound();
            }
            return View(tblJeu);
        }

        // POST: tblJeus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblJeu tblJeu = db.tblJeu.Find(id);
            db.tblJeu.Remove(tblJeu);
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
