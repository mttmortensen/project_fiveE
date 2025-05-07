using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Subclass
    {
        public int SubclassID { get; set; }
        public int ClassID { get; set; } // FK to Classes

        public string SubclassName { get; set; }
        public int EntryLevel { get; set; } = 3; // Most subclasses kick in at level 3
        public string Descriptions { get; set; } 

        public List<string> SubclassFeatures { get; set; } = new List<string>();
        public List<string> BonusProficiencies { get; set; } = new List<string>();
        public List<string> BonusSpells { get; set; } = new List<string>(); // Optional for casters

    }
}
