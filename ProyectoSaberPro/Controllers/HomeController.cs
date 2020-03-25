using ProyectoSaberPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace ProyectoSaberPro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            //var resultado = ApplicationRoleManager.Create(new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db)));
            var userList = db.Users.ToList();
            if (userList.Count == 0)
            {
                return RedirectToAction("Register", "Account");
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
        public ActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }
        
    }
}