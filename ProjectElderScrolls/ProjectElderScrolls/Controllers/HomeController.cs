using ProjectElderScrolls.Models;
using ProjectElderScrolls.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectElderScrolls.Controllers
{
    public class HomeController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUserVM AppUserVM)
        {
            var user = db.AppUsers.Where(x => x.UserName == AppUserVM.UserName && x.Password == AppUserVM.Password).FirstOrDefault();
            //the decision structure that checks if the user actually exists in the database to log into
            if (user != null)
            {
                //Cookie - client side
                //Session - server side
                Session["login"] = user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AppUser AppUser)
        {
            //the decision structure is for displaying the error messages
            if (ModelState.IsValid)
            {
                //the decision structure to see if any user with the same name or email exists
                if (db.AppUsers.Any(x => x.Email == AppUser.Email || x.UserName == AppUser.UserName))
                {
                    TempData["error"] = "User already exists";
                    return View();
                }
                else
                {
                    db.AppUsers.Add(AppUser);
                    db.SaveChanges();
                    return RedirectToAction("Login","Home");
                }

            }
            else
            {
                return View(AppUser);
            }

        }


    }
}