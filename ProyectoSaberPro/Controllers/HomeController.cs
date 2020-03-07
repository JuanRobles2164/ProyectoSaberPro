using ProyectoSaberPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoSaberPro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var userList = db.Users.ToList();
            if (userList.Count == 0)
            {
                //Aquí debería retornar a la vista de registro del primer primerísimo admin
                //Es básicamente la misma de todas xd pero se registra como admin
                //Sino entiende, es lo del requisito 3 del correo de Laura
                return View();
            } else {
                return View();
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RegistroPrimigenio()
        {
            ViewBag.Message = "";
            return View();
        }
        public ActionResult InvalidAccount()
        {
            return View();
        }
    }
}