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
    public class AdministradorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //Prueba de git al proyecto

        #region GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Administradores.ToList());
        }
        public ActionResult IndexAlumnos()
        {
            return View(db.Alumnos.ToList());
        }
        public ActionResult indexDocentes()
        {
            return View(db.Docentes.ToList());
        }

        #endregion

        #region  GET: Administrador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }
        public ActionResult DetailsAlumno(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }
        public ActionResult DetailsDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }
        #endregion

        #region GET: Administrador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Correo")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                db.Administradores.Add(administrador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administrador);
        }
        #endregion

        #region Edit

        #region GET: Administrador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }
        public ActionResult EditAlumno(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }
        public ActionResult EditDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        #endregion

        #region POST: Administrador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Correo")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrador);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDocente([Bind(Include = "ID,Correo,Nombres")] Docente docente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(docente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexDocentes");
            }
            return View(docente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAlumno([Bind(Include = "ID,Correo,Nombres,Apellidos,Semestre,Username")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexAlumnos");
            }
            return View(alumno);
        }
        #endregion

        #endregion

        #region GET: Administrador/Delete/5

        #region deleteAdmin
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administradores.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrador administrador = db.Administradores.Find(id);
            db.Administradores.Remove(administrador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region deleteAlumno
        public ActionResult DeleteAlumno(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Administrador/Delete/5
        public ActionResult DeleteAlumnoConfirmed(int id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumno);
            db.SaveChanges();
            return RedirectToAction("IndexAlumnos");
        }
        #endregion

        #region deleteDocente
        public ActionResult DeleteDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        // POST: Administrador/Delete/5
        public ActionResult DeleteDocenteConfirmed(int id)
        {
            Docente docente = db.Docentes.Find(id);
            db.Docentes.Remove(docente);
            db.SaveChanges();
            return RedirectToAction("IndexDocentes");
        }
        #endregion

        #endregion

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
