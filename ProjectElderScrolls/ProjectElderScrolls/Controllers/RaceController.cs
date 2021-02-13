using ProjectElderScrolls.Filters;
using ProjectElderScrolls.Models;
using ProjectElderScrolls.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectElderScrolls.Controllers
{
    public class RaceController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        public ActionResult Index()
        {
            return View(db.CharacterRaces.ToList());
        }

        [AuthFilter]
        public ActionResult AddCharacterRace()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCharacterRace(CharacterRace characterRace)
        {
            db.CharacterRaces.Add(characterRace);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCharacterRace(int raceId)
        {
            var characterRace = db.CharacterRaces.Find(raceId);
            if (characterRace != null)
            {
                db.CharacterRaces.Remove(characterRace);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateCharacterRace(int raceId)
        {
            var characterRace = db.CharacterRaces.Find(raceId);
            return View(characterRace);
        }

        [HttpPost]
        public ActionResult UpdateCharacterRace(CharacterRace characterRace)
        {
            var updated = db.CharacterRaces.Find(characterRace.RaceId);
            updated.RaceName = characterRace.RaceName;
            updated.Racial = characterRace.Racial;
            updated.Lore = characterRace.Lore;


            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}