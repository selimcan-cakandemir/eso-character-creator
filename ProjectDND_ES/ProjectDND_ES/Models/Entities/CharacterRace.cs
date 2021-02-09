using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDND_ES.Models.Entities
{
    public class CharacterRace
    {
        public int RaceId { get; set; }
        public string RaceName { get; set; }
        [MaxLength(5000)]
        public string Racial { get; set; }
        [MaxLength(5000)]
        public string Lore { get; set; }
    }
}