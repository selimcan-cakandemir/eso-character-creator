namespace ProjectDND_ES.Migrations
{
    using ProjectDND_ES.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectDND_ES.Models.Context.ProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjectDND_ES.Models.Context.ProjectDbContext context)
        {
            #region Classes
            List<CharacterClass> classes = new List<CharacterClass>
            {
                new CharacterClass{ClassName="Nightblade", Strength=5, Intelligence=4, Agility=8, WeaponDamage=70, SpellDamage=30, Lore="Spell and shadow are their friends. By darkness they move with haste, casting magic to benefit their circumstances."},
                new CharacterClass{ClassName="Monk", Strength=6, Intelligence=5, Agility=7, WeaponDamage=70, SpellDamage=30, Lore="Quick and cunning with the empty hand, they are strong in spirit. They prefer to solve conflict by arrow or by fist."},
                new CharacterClass{ClassName="Battlemage", Strength=6, Intelligence=6, Agility=4, WeaponDamage=50, SpellDamage=60, Lore="Able to resolve most conflicts with either spell or sword. They are a deadly mix of scholar and soldier."},
                new CharacterClass{ClassName="Knight", Strength=8, Intelligence=3, Agility=3, WeaponDamage=85, SpellDamage=10, Lore="The most noble of all combatants. Strong in body and in character."},

            };

            foreach (var characterClass in classes)
            {
                context.CharacterClasses.Add(characterClass);
                context.SaveChanges();
            }
            #endregion

            #region Races
            List<CharacterRace> races = new List<CharacterRace>
            {
                new CharacterRace{RaceName="Altmer",Racial="Fortified Magicka",Lore="Altmer are the light-skinned and tall Elves of the Summerset Isles."},
                new CharacterRace{RaceName="Argonian",Racial="Resist Disease",Lore="The Argonians are the reptiloid natives of the Black Marsh of southern Tamriel."},
                new CharacterRace{RaceName="Bosmer",Racial="Beast Tongue",Lore="Across the Empire, the various barbarian Elven clanfolk of the Western Valenwood forests are collectively referred to as Wood Elves."},
                new CharacterRace{RaceName="Breton",Racial="Dragon Skin",Lore="Bretons are humans with a touch of elven ancestry and they populate the province of High Rock."},
                new CharacterRace{RaceName="Dunmer",Racial="Ancestor Guardian",Lore="The Dunmer, more commonly referred to as Dark Elves, are the dark skinned elves originally from the province of Morrowind."},
                new CharacterRace{RaceName="Imperial",Racial="Voice of the Emperor",Lore="Imperials, also known as Cyrodilics, are humans native to the civilized, cosmopolitan province of Cyrodiil."},
                new CharacterRace{RaceName="Khajiit",Racial="Eye of Night",Lore="Khajiit are one of the humanoid races which inhabit the continent of Tamriel, primarily their home province of Elsweyr."},
                new CharacterRace{RaceName="Nord",Racial="Nordic Frost",Lore="Originally hailing from the province of Skyrim, they are a tall and fair-haired people. Strong and hardy, Nords are famous for their resistance to cold. They are highly talented warriors."},
                new CharacterRace{RaceName="Orsimer",Racial="Berserk",Lore="Orcs, also called Orsimer are the large, green-skinned natives of the Wrothgarian Mountains, Dragontail, and Orsinium."},
                new CharacterRace{RaceName="Redguard",Racial="Adrenaline Rush",Lore="The most naturally talented warriors in Tamriel, the dark-skinned Redguards of Hammerfell seem born to battle, though their pride and fierce independence of spirit makes them more suitable as scouts or skirmishers, or as free-ranging heroes and adventurers, than as rank-and-file soldiers."}              
            };

            foreach (var characterRace in races)
            {
                context.CharacterRaces.Add(characterRace);
                context.SaveChanges();
            }
            #endregion

        }
    }
}
