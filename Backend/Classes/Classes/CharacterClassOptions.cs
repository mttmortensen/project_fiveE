using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterClassOptions
    {
        public int CharClassOpID { get; set; }
        public int CharacterID { get; set; }
        public int ClassID { get; set; }

        public List<string> AvailableWeaponProficiencies { get; set; } = new();
        public List<string> AvailableArmorProficiencies { get; set; } = new();

        // Will evolve into ClassPath object
        public List<string> AvailableClassPaths { get; set; } = new(); 
    }

}
