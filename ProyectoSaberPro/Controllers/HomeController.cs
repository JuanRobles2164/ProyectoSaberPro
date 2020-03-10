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
                return RedirectToAction("Login", "Account");
            } else {
                return View();
            }
            
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