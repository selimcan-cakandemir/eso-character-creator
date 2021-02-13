using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectElderScrolls.Models.Entities
{
    public class CharacterClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int WeaponDamage { get; set; }
        public int SpellDamage { get; set; }
        [MaxLength(5000)]
        public string Lore { get; set; }
    }
}