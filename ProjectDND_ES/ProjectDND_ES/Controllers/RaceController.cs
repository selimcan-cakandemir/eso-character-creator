using ProjectDND_ES.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDND_ES.Controllers
{
    public class RaceController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        public ActionResult Index()
        {
            return View(db.CharacterRaces.ToList());
        }
    }
}