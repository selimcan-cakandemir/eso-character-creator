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
    public class ClassController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        public ActionResult Index()
        {
            return View(db.CharacterClasses.ToList());
        }

        [AuthFilter]
        public ActionResult AddCharacterClass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCharacterClass(CharacterClass characterClass)
        {
            db.CharacterClasses.Add(characterClass);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCharacterClass(int classId)
        {
            var characterClass = db.CharacterClasses.Find(classId);
            if (characterClass != null)
            {
                db.CharacterClasses.Remove(characterClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateCharacterClass(int classId)
        {
            var characterClass = db.CharacterClasses.Find(classId);
            return View(characterClass);
        }

        [HttpPost]
        public ActionResult UpdateCharacterClass(CharacterClass characterClass)
        {
            var updated = db.CharacterClasses.Find(characterClass.ClassId);
            updated.ClassName = characterClass.ClassName;
            updated.Strength = characterClass.Strength;
            updated.Intelligence = characterClass.Intelligence;
            updated.Agility = characterClass.Agility;
            updated.WeaponDamage = characterClass.WeaponDamage;
            updated.SpellDamage = characterClass.SpellDamage;
            updated.Lore = characterClass.Lore;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}