using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Web.Mvc;

namespace ProjetTexcel_WEB.Controllers
{
    
    public class RoleController:Controller
    {
        bdTexelFredAlexEntities context;

        public RoleController()
        {
            context = new bdTexelFredAlexEntities();
        }

        public ActionResult Index()
        {
            var Roles = context.tblRole.ToList();
            return View(Roles);
        }

        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.tblRole.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}