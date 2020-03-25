using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoSaberPro.Models;

namespace ProyectoSaberPro.Controllers
{
    public class AlumnoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Alumno
        [Authorize(Roles =("Alumno"))]
        public ActionResult Index()
        {
            return View();
        }

        // POST: Alumno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = ("Alumno"))]
        public ActionResult Create([Bind(Include = "ID,Correo,Nombres,Apellidos,Semestre")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumnos.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        // GET: Alumno/Edit/5
        [Authorize(Roles = ("Alumno"))]
        public ActionResult Edit(string email)
        {
            
            if (email == null)
            {
                var test = User.Identity.Name;
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = null;
            try
            {
                alumno = db.Alumnos.First(x => x.Correo == email);
            }
            catch (Exception e)
            {
                return HttpNotFound(e.Message);
            }
            
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = ("Alumno"))]
        public ActionResult Edit([Bind(Include = "ID,Correo,Nombres,Apellidos,Semestre,Username")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumno);
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
