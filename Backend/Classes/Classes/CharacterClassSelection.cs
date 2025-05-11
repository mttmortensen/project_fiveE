using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterClassSelection
    {
        public int CharClassSelectID { get; set; }
        public int CharacterID { get; set; }
        public int ClassID { get; set; }

        public List<string> SelectedWeaponProficiencies { get; set; } = new();
        public List<string> SelectedArmorProficiencies { get; set; } = new();
        public List<string> SelectedClassPaths { get; set; } = new();
    }

}
